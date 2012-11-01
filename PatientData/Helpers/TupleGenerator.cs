using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Helpers
{
    using Entities;

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
                VisitCombinations(visits.Skip(i + 1), n - 1).Select(c => (new[] { v }).Concat(c)));
        }

    }
}
