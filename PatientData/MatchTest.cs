using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData
{
    using Data;
    using Entities;
    using Entities.Actors;

    class MatchTest
    {
        private static readonly DateTime START = new DateTime(2011, 01, 01);
        private static readonly DateTime END = new DateTime(2011, 12, 31);
        private static readonly int VISITS_LOWERBOUND = 10;
        private static readonly int VISITS_HIGHERBOUND = 20;
        private static readonly float MATCHING_RATIO = 0.5f;
        private static readonly int MATCHINGPATIENTS_LOWERBOUND = 4;

        private DBProxy _db;
        private Queries _q;

        private DateTime _start;
        private HealthProfessional hp;

        public MatchTest(int patients)
        {
            _db = new SQLiteProxy();
            _db.Init("Data" + System.IO.Path.DirectorySeparatorChar + "patientData");

            _q = new Queries(_db);

            _start = START;
            
            /* Create 1 Health Professional and add to DB */
            hp = createHealthProfessional(1).FirstOrDefault();

            /* Create new patients, and add to DB */
            IEnumerable<Patient> newPatients = createPatients(patients);
            
            /* Create collection consisting of the 10% of the total patients */
            IEnumerable<Patient> nonMatchingPatients = new List<Patient>(newPatients.Take<Patient>((int)Math.Ceiling(newPatients.Count<Patient>() * 0.1)));
            /* Create non-matching visit records for the given patients, and add to DB */
            createNonMatchingRecords(nonMatchingPatients);

            /* Create collection the size of 10% of the total patients (minimum 4), extracted from the new patients minus the patients already used */
            IEnumerable<Patient> matchingPatients = new List<Patient>(newPatients.Except<Patient>(nonMatchingPatients).Take<Patient>(Math.Max((int)Math.Ceiling(newPatients.Count<Patient>() * 0.1), 4)));
            /* Create matching visit records for the given patients, and add to DB */
            createMatchingRecords(matchingPatients, MATCHING_RATIO);

            /* Create collection of unused patients */
            IEnumerable<Patient> remainingPatients = new List<Patient>(newPatients.Except<Patient>(nonMatchingPatients).Except<Patient>(matchingPatients));
            /* Create matching visit records for the given patients, and add to DB */
            createRemainingRecords(remainingPatients);
        }

        private IEnumerable<Patient> createPatients(int patients)
        {
            List<Patient> result = new List<Patient>(patients);
            Patient p = null;
            for (int i = 1; i <= patients; i++)
            {
                p = new Patient(i);
                _db.InsertPatient(ref p);
                result.Add(p);
            }
            return result;
        }

        private IEnumerable<HealthProfessional> createHealthProfessional(int healthprofessionals)
        {
            List<HealthProfessional> result = new List<HealthProfessional>(healthprofessionals);
            HealthProfessional hp = null;
            for (int i = 1; i <= healthprofessionals; i++)
            {
                hp = new HealthProfessional(i);
                _db.InsertHealthProfessional(ref hp);
                result.Add(hp);
            }
            return result;
        }

        /**
         *  <summary>
         *      Creates visit records that satisfy the following criteria:
         *          10% of the patients have none of their visits match those of other patients.
         *      This function should be called before the other visit creation functions.
         *  </summary>
         *  
         *  <param name="patients">
         *      Patients to create unique records for
         *  </param>
         */
        private void createNonMatchingRecords(IEnumerable<Patient> patients)
        {
            foreach (Patient p in patients)
            {
                for (int i = (new Random()).Next(VISITS_LOWERBOUND, VISITS_HIGHERBOUND + 1); i > 0; i--)
                {
                    _db.InsertVisit(new Visit(p, hp, _start, new ProfessionalAct(1, 1), Rational.initial));
                    _start = _start.AddDays(1);
                }
            }
        }

        /**
         *  <summary>
         *      Creates visit records that satisfy the following criteria:
         *          10% of the patients have at least 50% of their visits match those of at least 
         *          4 other patients in the database.
         *      Create any non-matching visits before running this function.
         *  </summary>
         *  
         *  <param name="patients">
         *      Patients to create records for
         *  </param>
         *  <param name="matchingRatio">
         *      Ratios of visits that should match other patients visits
         *  </param>
         */
        private void createMatchingRecords(IEnumerable<Patient> patients, float matchingRatio)
        {
            /*
             * index - the current index in the patient IEnumerable (patients)
             * matching - the number of patients to have matching visits for
             * matchingRatio (and related variables) - fraction of visits to match across patients
             */

            int index = 0;
            while (index < patients.Count<Patient>())
            {
                /* Set number of matching patients to be between 4 and number of total patients provided */
                int matching = MATCHINGPATIENTS_LOWERBOUND + (new Random()).Next(0, patients.Count<Patient>() - index);
                if ((index + matching) > patients.Count<Patient>())
                {
                    matching = patients.Count<Patient>() - index;
                }

                int numberOfVisits = (new Random()).Next(VISITS_LOWERBOUND, VISITS_HIGHERBOUND + 1);
                
                float actualMatchingRatio = matchingRatio;
                double matchingRandomBuffer = (new Random()).NextDouble() - matchingRatio;
                if (matchingRandomBuffer > 0)
                    actualMatchingRatio += (float) matchingRandomBuffer;
                int matchingVisits = (int)Math.Ceiling(numberOfVisits * actualMatchingRatio);

                /* Create matching visits - random number of visits times semi-random matching ratio */
                for (int i = 0; i < matchingVisits; i++)
                {
                    for (int k = 0; k < matching; k++)
                    {
                        _db.InsertVisit(
                            new Visit(
                                patients.ElementAt<Patient>(index + k),
                                hp,
                                _start.AddDays(index),
                                new ProfessionalAct(1, 1),
                                Rational.initial));
                    }
                }

                /* Create remaining visits - Random date (after _start) and random Rational */
                for (int k = 0; k < matching; k++)
                {
                    for (int j = matchingVisits; j < numberOfVisits; j++)
                    {
                        _db.InsertVisit(
                            new Visit(
                                patients.ElementAt<Patient>(index + k),
                                hp,
                                new DateTime(_start.Year, (new Random()).Next(_start.Month + 1, 13), (new Random()).Next(1, 29)),
                                new ProfessionalAct(1, 1),
                                (Rational)(new Random()).Next(1, 6)));
                    }
                }

                /* Skip the number of Patients handled */
                index += matching;
            }
        }

        /**
         *  <summary>
         *      Creates visit records for the patients provided. Date and Rational will be random
         *      (Date will be after last used non-matching date).
         *      Create any non-matching visits before running this function.
         *  </summary>
         *  
         *  <param name="patients">
         *      Patients to create records for
         *  </param>
         */
        private void createRemainingRecords(IEnumerable<Patient> patients)
        {
            foreach (Patient p in patients)
            {
                for (int i = (new Random()).Next(VISITS_LOWERBOUND, VISITS_HIGHERBOUND + 1); i > 0; i--)
                {
                    _db.InsertVisit(
                        new Visit(
                            p,
                            hp,
                            new DateTime(_start.Year, (new Random()).Next(_start.Month + 1, 13), (new Random()).Next(1, 29)),
                            new ProfessionalAct(1, 1),
                            (Rational)(new Random()).Next(1, 6)));
                }
            }
        }
    }
}
