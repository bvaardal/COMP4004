using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities.Actors
{
    class Patient : Actor
    {
        public Patient(long pID = -1)
            : base(pID)
        { }
    }
}
