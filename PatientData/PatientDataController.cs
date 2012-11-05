using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientData
{
    using GUI;
    using Data;
    using Entities;

    class PatientDataController
    {
        private MainWindow view;
        private DBProxy model;

        public PatientDataController()
        {
            /* View */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            view = new MainWindow(this);
            Application.Run(view);
        }

        /**
         *  <summary>
         *      Either by opens the DB in the given path, or creates it.
         *  </summary>
         *  
         *  <param name="path">
         *      The DB to use.
         *  </param>
         *  <param name="newDB">
         *      Whether to create the given Path (true), or open an existing DB (false).
         *  </param>
         */
        public void InitModel(String path, bool newDB)
        {
            model = new SQLiteProxy();
            model.Init(path, newDB);
        }

        /**
         *  <summary>
         *      Determine whether there is a model (DB) in place.
         *  </summary>
         *  
         *  <returns>
         *      True if model is initialized, false otherwise.
         *  </returns>
         */
        public bool IsModelInitialized()
        {
            return model != null;
        }

        /**
         *  <summary>
         *      Gets all ACVs (of same size as the given CM) for the given patient that match the
         *      given CM.
         *  </summary>
         *  
         *  <param name="pID">
         *      The ID of the patient to get ACVs for
         *  </param>
         *  <param name="cms">
         *      The CM to compare against
         *  </param>
         */
        public IEnumerable<IEnumerable<Visit>> GetMatchingACVs(HashSet<CMPair> cm, IEnumerable<Patient> ps)
        {
            List<IEnumerable<Visit>> result = new List<IEnumerable<Visit>>();

            IEnumerable<IEnumerable<Visit>> acvs;
            foreach (Patient p in ps)
            {
                acvs = model.GetACVs(p, cm.Count<CMPair>());

                foreach (IEnumerable<Visit> acv in acvs)
                {
                    bool match = true;
                    foreach (Visit v in acv)
                    {
                        match &= cm.Contains<CMPair>(v, new CMPairMatcher());
                    }
                    if (match)
                    {
                        result.Add(acv);
                    }
                }
            }

            return (IEnumerable<IEnumerable<Visit>>)result;
        }

        #region Test Data
        /**
         *  <summary>
         *      Inserts test data into the model according to the specifications in Iter2:
         *          A Patients with B matching Visits
         *          C Patients with D random Visits
         *  </summary>
         *  
         *  <param name="matchingPatients">
         *      Number of Patients whos Visits should match.
         *  </param>
         *  <param name="matchingVisits">
         *      Number of Visits for matching Patients (per Patient)
         *  </param>
         *  <param name="randomPatients">
         *      Number of Patients whos Visits should be random.
         *  </param>
         *  <param name="randomVisits">
         *      Number of random Visits per Patient.
         *  </param>
         */
        public void CreateTestData(int matchingPatients, int matchingVisits, int randomPatients, int randomVisits)
        {
            createHealthProfessionals(3);
            createMatchingRecords(matchingPatients, matchingVisits);
            createRandomRecords(randomPatients, randomVisits);
        }

        private void createMatchingRecords(int patients, int visits)
        {
            /* Create patients */
            IEnumerable<Patient> ps = createPatients(patients);

            /* Set matching variables */
            IEnumerable<HealthProfessional> hps = model.GetHealthProfessionals();
            DateTime dt = DateTime.Parse("2011-01-01");
            Rational r = Rational.initial;
            ProfessionalAct pa = new ProfessionalAct(1, 1);
            
            /* Create visits */
            for (int i = 0; i < visits; i++)
            {
                foreach (Patient p in ps)
                {
                    model.InsertVisit(new Visit(
                        p,
                        hps.ElementAt<HealthProfessional>((new Random()).Next(0, hps.Count())),
                        dt, 
                        new ProfessionalAct((new Random()).Next(1, 101), (new Random()).Next(1, 201)), 
                        r));
                }

                dt = dt.AddDays(1);
            }
        }

        private void createRandomRecords(int patients, int visits)
        {
            IEnumerable<Patient> ps = createPatients(patients);
            IEnumerable<HealthProfessional> hps = model.GetHealthProfessionals();

            foreach (Patient p in ps)
            {
                for (int i = 0; i < visits; i++)
                {
                    model.InsertVisit(new Visit(
                            p,
                            hps.ElementAt<HealthProfessional>((new Random()).Next(0, hps.Count())),
                            new DateTime(2011, (new Random()).Next(1, 13), (new Random()).Next(1, 29)),
                            new ProfessionalAct((new Random()).Next(1, 101), (new Random()).Next(1, 201)),
                            (Rational)(new Random()).Next(1, 6)));
                }
            }
        }

        private IEnumerable<Patient> createPatients(int patients)
        {
            List<Patient> ps = new List<Patient>(patients);
            for (int i = 0; i < patients; i++)
            {
                Patient p = new Patient();
                ps.Add(p);
                model.InsertPatient(ref p);
            }
            return ps;
        }


        private void createHealthProfessionals(int healthProfessionals)
        {
            for (int i = 0; i < healthProfessionals; i++)
            {
                HealthProfessional hp = new HealthProfessional();
                model.InsertHealthProfessional(ref hp);
            }
        }
        #endregion

        /**
         *  <summary>
         *      Search the DB for all Patients
         *  </summary>
         *  
         *  <returns>
         *      The list of all Patients.
         *  </returns>
         */
        public List<Patient> GetPatients()
        {
            if (model == null)
            {
                return new List<Patient>();
            }
            else
            {
                return model.GetPatients();
            }

        }

        /**
         *  <summary>
         *      Search the DB for visits by a specific Patient.
         *  </summary>
         *  
         *  <param name="p">
         *      The Patient for whom to get visits.
         *  </param>
         *  
         *  <returns>
         *      The list of visits by the specified Patient.
         *  </returns>
         */
        public List<Visit> GetVisitsByPatient(Patient p)
        {
            if (model == null)
            {
                return new List<Visit>();
            }
            else
            {
                return model.GetVisitsByPatient(p);
            }
        }

        public IEnumerable<IEnumerable<Visit>> GetACVs(Patient p, int n)
        {
            return model.GetACVs(p, n);
        }

        /**
         *  <summary>
         *      Searches the DB for Patients who satisfy the criterion to be considered a safe 
         *      Patient:
         *          All ACVs of the Patient must have at least one matching ACV in at least 4
         *          other unqiue Patients.
         *  </summary>
         *  
         *  <param name="acvSize">
         *      The size of the ACVs used when matching Patients.
         *  </param>
         *  
         *  <returns>
         *      The list of safe Patients.
         *  </returns>
         */
        public IEnumerable<Patient> getSafePatients(int acvSize)
        {
            List<Patient> result = new List<Patient>();
            IEnumerable<Patient> ps = model.GetPatients();
            Dictionary<Patient, IEnumerable<IEnumerable<Visit>>> patientAcvs = new Dictionary<Patient, IEnumerable<IEnumerable<Visit>>>();

            foreach (Patient p in ps)
            {
                patientAcvs.Add(p, model.GetACVs(p, acvSize));
            }

            /* Patient p1 is the patient whos safeness is being determined */
            foreach (Patient p1 in ps)
            {
                bool safe = true;

                /* The ACV's of p1 are checked for a match in 4 other patients */
                IEnumerable<IEnumerable<Visit>> acvs1;
                patientAcvs.TryGetValue(p1, out acvs1);
                foreach (IEnumerable<Visit> acv1 in acvs1)
                {
                    int matches = 0;
                    /* Traverse other patients (not p1) until 4 Patient with an ACV matching acv1 are found */
                    foreach (Patient p2 in ps)
                    {
                        if (p2 == p1)
                        {
                            continue;
                        }

                        /* Check ACVs of other patient for matches to acv1 */
                        IEnumerable<IEnumerable<Visit>> acvs2;
                        patientAcvs.TryGetValue(p2, out acvs2);
                        foreach (IEnumerable<Visit> acv2 in acvs2)
                        {
                            List<CMPair> temp = new List<CMPair>();
                            foreach (Visit v in acv2)
                            {
                                temp.Add((CMPair)v);
                            }

                            bool match = true;
                            foreach (Visit v in acv1)
                            {
                                match &= temp.Contains(v, new CMPairMatcher());
                            }

                            /* Found matching ACV, so move on to next patient to match */
                            if (match)
                            {
                                matches++;
                                break;
                            }
                        }

                        /* If 4 matching ACV's from unique patients are found, acv1 is safe */
                        if (matches == 4)
                        {
                            break;
                        }
                    }

                    /* If not 4 matching ACV's from unique patients were found, p1 is unsafe (conclusion). */
                    if (matches != 4)
                    {
                        safe = false;
                        break;
                    }
                }
                if (safe)
                {
                    result.Add(p1);
                }
            }

            return result;
        }

        /**
         *  <summary>
         *      Searches the DB for Patients who do not satisfy the criterion to be considered a
         *      safe Patient:
         *          All ACVs of the Patient must have at least one matching ACV in at least 4
         *          other unqiue Patients.
         *  </summary>
         *  
         *  <param name="acvSize">
         *      The size of the ACVs used when matching Patients.
         *  </param>
         *  
         *  <returns>
         *      For each unsafe Patient, the first ACV that was not matched.
         *  </returns>
         */
        public IEnumerable<IEnumerable<Visit>> getUnsafePatients(int acvSize)
        {
            List<IEnumerable<Visit>> result = new List<IEnumerable<Visit>>();
            IEnumerable<Patient> ps = model.GetPatients();
            Dictionary<Patient, IEnumerable<IEnumerable<Visit>>> patientAcvs = new Dictionary<Patient, IEnumerable<IEnumerable<Visit>>>();

            foreach (Patient p in ps)
            {
                patientAcvs.Add(p, model.GetACVs(p, acvSize));
            }

            /* Patient p1 is the patient whos safeness is being determined */
            foreach (Patient p1 in ps)
            {
                /* The ACV's of p1 are checked for a match in 4 other patients */
                IEnumerable<IEnumerable<Visit>> acvs1;
                patientAcvs.TryGetValue(p1, out acvs1);
                foreach (IEnumerable<Visit> acv1 in acvs1)
                {
                    int matches = 0;
                    /* Traverse other patients (not p1) until 4 Patient with an ACV matching acv1 are found */
                    foreach (Patient p2 in ps)
                    {
                        if (p2 == p1)
                        {
                            continue;
                        }

                        /* Check ACVs of other patient for matches to acv1 */
                        IEnumerable<IEnumerable<Visit>> acvs2;
                        patientAcvs.TryGetValue(p2, out acvs2);
                        foreach (IEnumerable<Visit> acv2 in acvs2)
                        {
                            /* Work-around for cast problem (IEnumerable<Visit> to IEnumerable<CMPair>) */
                            List<CMPair> temp = new List<CMPair>();
                            foreach (Visit v in acv2)
                            {
                                temp.Add((CMPair)v);
                            }

                            bool match = true;
                            foreach (Visit v in acv1)
                            {
                                match &= temp.Contains(v, new CMPairMatcher());
                            }

                            /* Found matching ACV, so move on to next patient to match */
                            if (match)
                            {
                                matches++;
                                break;
                            }
                        }

                        /* If 4 matching ACV's from unique patients are found, acv1 is safe */
                        if (matches == 4)
                        {
                            break;
                        }
                    }

                    /* If not 4 matching ACV's from unique patients were found, p1 is unsafe (conclusion). */
                    if (matches != 4)
                    {
                        result.Add(acv1);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
