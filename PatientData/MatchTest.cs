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
        private static DateTime START = new DateTime(2011, 01, 01);
        private static DateTime END = new DateTime(2011, 12, 31);

        private DBProxy _db;
        private Queries _q;

        public MatchTest(int patients)
        {
            _db = new SQLiteProxy();
            _db.Init("Data" + System.IO.Path.DirectorySeparatorChar + "patientData");

            _q = new Queries(_db);

            /* Create new patients, and add to DB */
            IEnumerable<Patient> newPatients = createPatients(patients);
            
            /* Create 1 Health Professional and add to DB */
            createHealthProfessional(1);
            
            /* Create collection consisting of the 10% of the total patients */
            IEnumerable<Patient> nonMatchingPatients = new List<Patient>(newPatients.Take<Patient>((int)Math.Ceiling(newPatients.Count<Patient>() * 0.1)));
            /* Create non-matching visit records for the given patients, and add to DB */
            createNonMatchingRecords(nonMatchingPatients);

            /* Create collection the size of 10% of the total patients, extracted from the new patients minus the patients already used */
            IEnumerable<Patient> matchingPatients = new List<Patient>(newPatients.Except<Patient>(nonMatchingPatients).Take<Patient>((int)Math.Ceiling(newPatients.Count<Patient>() * 0.1)));
            /* Create matching visit records for the given patients, and add to DB */
            createMatchingRecords(matchingPatients, 0.5f);
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

        private void createHealthProfessional(int healthprofessional)
        {
            HealthProfessional hp = null;
            for (int i = 1; i <= healthprofessional; i++)
            {
                hp = new HealthProfessional(i);
                _db.InsertHealthProfessional(ref hp);
            }
        }

        /**
         *  <summary>
         *      Creates visit records that satisfy the following criteria:
         *          10% of the patients have none of their visits match those of other patients
         *  </summary>
         *  
         *  <param name="records">
         *      Number of patients to create records for (10% of original number).
         *  </param>
         *  
         *  <returns>
         *      First available date, i.e. not used by non-matching records.
         *  </returns>
         */
        private DateTime createNonMatchingRecords(IEnumerable<Patient> patients)
        {
            DateTime dt = START;


            foreach (Patient p in patients)
            {
            }

            return DateTime.Now;
        }

        /**
         *  <summary>
         *      Creates visit records that satisfy the following criteria:
         *          10% of the patients have at least 50% of their visits match those of at least 
         *          4 other patients in the database
         *  </summary>
         *  
         *  <param name="records">
         *      Number of patients to create records for (10% of original number).
         *  </param>
         *  
         *  <returns>
         *      First available date, i.e. not used by non-matching records.
         *  </returns>
         */
        private void createMatchingRecords(IEnumerable<Patient> patients, float matchingRatio)
        {
        }

        private void createRemainingRecords()
        {
        }
    }
}
