using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Data
{
    using Entities;
    using Entities.Actors;
    using Structures;

    class Queries
    {
        private DBProxy _dataSource;

        public Queries(DBProxy dataSource)
        {
            _dataSource = dataSource;
        }


        public HashSet<Visit[]> GetACVs(Patient p, int n)
        {
            HashSet<Visit[]> result = new HashSet<Visit[]>();

            if (n < 1 || n > 5)
            {
                throw new TupleSizeException(n);
            }

            List<Visit> visits = _dataSource.GetVisitsByPatient(p);

            Visit[] tuple = new Visit[n];


            return null;
        }
    }

    class TupleSizeException : Exception
    {
        public TupleSizeException(int n)
            : base("Tuple size (" + n + ") is not supported")
        { }
    }
}
