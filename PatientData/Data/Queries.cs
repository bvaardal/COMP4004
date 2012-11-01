using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Data
{
    using Entities;

    class Queries
    {
        private DBProxy _dataSource;

        public Queries(DBProxy dataSource)
        {
            _dataSource = dataSource;
        }

        /**
         *  <summary>
         *      Gets all Actual Combinations of Visits (ACV) for the Patient p in nTuples of a
         *      given size n.
         *  </summary>
         *  
         *  <param name="p">
         *      The patient to get ACVs for.
         *  </param>
         *  <param name="n">
         *      The size of the nTuple.
         *  </param>
         */
        public IEnumerable<IEnumerable<Visit>> GetACVs(Patient p, int n)
        {
            if (n < 1 || n > 5)
            {
                throw new TupleSizeException(n);
            }
            return TupleGenerator.VisitCombinations(_dataSource.GetVisitsByPatient(p), n);
        }
    }

    class TupleSizeException : Exception
    {
        public TupleSizeException(int n)
            : base("Tuple size (" + n + ") is not supported")
        { }
    }

    static class TupleGenerator
    {
        /**
         *  <summary>
         *      Wow...
         *      http://stackoverflow.com/questions/127704/algorithm-to-return-all-combinations-of-k-elements-from-n
         *  </summary>
         */
        public static IEnumerable<IEnumerable<Visit>> VisitCombinations(IEnumerable<Visit> visits, int n)
        {
            return n == 0 ? new[] { new Visit[0] } :
              visits.SelectMany((v, i) =>
                VisitCombinations(visits.Skip(i + 1), n - 1).Select(c => (new[] {v}).Concat(c)));
        }

    }
}
