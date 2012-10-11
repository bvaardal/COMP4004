using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Data
{
    using Entities;
    using Entities.Actors;

    class MemoryProxy : DBProxy
    {
        private static long PID = 1;
        private static long HPID = 1;

        private Dictionary<Patient, List<Visit>> visits = null;
        private List<Patient> patients = null;
        private List<HealthProfessional> healthProfessionals = null;

        public MemoryProxy()
        {
            visits = new Dictionary<Patient, List<Visit>>();
            patients = new List<Patient>();
            healthProfessionals = new List<HealthProfessional>();
        }

        public void Init(String dbName, bool newDB = false)
        { }

        public void InsertPatient(ref Patient p)
        {
            patients.Add(p);
            p.UID = PID++;
        }

        public void InsertHealthProfessional(ref HealthProfessional hp)
        {
            healthProfessionals.Add(hp);
            hp.UID = HPID++;
        }

        public void InsertVisit(Visit v)
        {
            if (!visits.ContainsKey(v.Patient))
            {
                List<Visit> pVisits = new List<Visit>();
                pVisits.Add(v);
                visits.Add(v.Patient, pVisits);
            }
            else
            {
                List<Visit> pVisits = null;
                visits.TryGetValue(v.Patient, out pVisits);
                pVisits.Add(v);
            }
        }

        public List<Visit> GetVisitsByPatient(Patient p)
        {
            List<Visit> result = null;
            visits.TryGetValue(p, out result);
            return result;
        }

        public Patient GetPatientByID(long pID)
        {
            foreach (Patient p in patients)
            {
                if (p.UID == pID)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
