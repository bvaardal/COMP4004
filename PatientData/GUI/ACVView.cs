using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.GUI
{
    using Entities;

    class ACVView
    {
        private IEnumerable<Visit> visits;

        public ACVView(IEnumerable<Visit> c)
        {
            visits = c;
        }

        public override string ToString()
        {
            string result = "";

            foreach (Visit v in visits)
            {
                result += v;
            }

            return result;
        }
    }
}
