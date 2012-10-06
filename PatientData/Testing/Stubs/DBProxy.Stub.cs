using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Testing.Stubs
{
    using DB;
    using Entities;
    using Entities.Actors;

    class DBProxy_Stub : DBProxy
    {
        private Dictionary<Patient, List<Visit>> visits = null;

        public DBProxy_Stub()
        {
            visits = new Dictionary<Patient, List<Visit>>();
        }

        public override void Init(String dbName, bool newDB = false)
        {
        }

        public override void InsertPatient(ref Patient p)
        {
        }

        public override void InsertHealthProfessional(ref HealthProfessional hp)
        {
        }

        public override void InsertVisit(Visit v)
        {
            if (visits.ContainsKey(v.Patient))
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

        public override List<Visit> GetVisitsByPatient(Patient p)
        {
            List<Visit> result = null;
            visits.TryGetValue(p, out result);
            return result;
        }
    }
}
