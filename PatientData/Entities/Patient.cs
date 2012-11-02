using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities
{
    class Patient : Actor
    {
        public Patient(long pID = -1)
            : base(pID)
        { }

        public override string ToString()
        {
            return "Patient " + UID;
        }
    }
}
