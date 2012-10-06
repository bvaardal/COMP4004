using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Data
{
    using Entities;
    using Entities.Actors;

    interface DBProxy
    {
        void Init(String dbName, bool newDB = false);
        void InsertPatient(ref Patient p);
        void InsertHealthProfessional(ref HealthProfessional hp);
        void InsertVisit(Visit v);
        List<Visit> GetVisitsByPatient(Patient p);
    }
}
