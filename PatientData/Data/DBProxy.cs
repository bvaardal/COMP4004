using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Data
{
    using Entities;

    interface DBProxy
    {
        void Init(String dbName, bool newDB = false);
        void InsertPatient(ref Patient p);
        void InsertHealthProfessional(ref HealthProfessional hp);
        void InsertVisit(Visit v);
        List<Visit> GetVisitsByPatient(Patient p);
        Patient GetPatientByID(long pID);
        List<Patient> GetPatients();
        List<HealthProfessional> GetHealthProfessionals();
        IEnumerable<IEnumerable<Visit>> GetACVs(Patient p, int n);
        int PatientVisitCount(Patient p);
    }

    class DBException : Exception
    {
        public DBException(String s)
            : base(s)
        { }
    }

    class TupleSizeException : Exception
    {
        public TupleSizeException(int n)
            : base("Tuple size (" + n + ") is not supported")
        { }
    }
}
