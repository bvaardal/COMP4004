using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Entities
{
    class HealthProfessional : Actor
    {
        /**
         *  <summary>
         *  </summary>
         *  
         *  <param name="hpID">
         *      Should be retrieved from data source.
         *  </param>
         */
        public HealthProfessional(long hpID = -1)
            : base(hpID)
        {
            if (hpID > 100)
            {
                throw new InvalidParameterException("Invalid Health Professional ID (" + hpID + ").");
            }
        }
    }
}
