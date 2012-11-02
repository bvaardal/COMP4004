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

        public void InitModel(String path, bool newDB)
        {
            model = new SQLiteProxy();
            model.Init(path, newDB);
        }

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

        /**
         *  <summary>
         *      Creates test data for the current model
         *  </summary>
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
    }
}
