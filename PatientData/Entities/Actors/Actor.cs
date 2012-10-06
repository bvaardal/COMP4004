using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities.Actors
{
    abstract class Actor
    {
        public long UID { get; set; }

        public Actor(long uID)
        {
            UID = uID;
        }
    }
}
