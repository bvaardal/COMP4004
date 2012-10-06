using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData
{
    using Data;
    using Entities;
    using Entities.Actors;

    class MatchTest
    {
        private DBProxy _db;

        public MatchTest(int patients)
        {
            _db = new SQLiteProxy();
            _db.Init("Data" + System.IO.Path.DirectorySeparatorChar + "patientData");

            createNonMatchingRecords(patients);
        }

        /**
         *  <summary>
         *      Creates visit records that satisfy the following criteria:
         *          10% of the patients have at least 50% of their visits match those of at least 
         *          4 other patients in the database
         *  </summary>
         *  
         *  <param name="records">
         *      Number of patients to create records for (10% of original number).
         *  </param>
         *  
         *  <returns>
         *      First available date, i.e. not used by non-matching records.
         *  </returns>
         */
        private DateTime createNonMatchingRecords(int patients)
        {


            return DateTime.Now;
        }

        private void createMatchingRecords()
        {
        }

        private void createRemainingRecords()
        {
        }
    }
}
