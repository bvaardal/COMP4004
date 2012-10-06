using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xunit;

namespace PatientData.Testing.UnitTests
{
    using Data;
    using Entities;
    using Entities.Actors;

    public class DBProxy_UnitTest
    {
        public DBProxy_UnitTest()
        {
            if (!Directory.Exists(TestGlobals.TEMP_DIR))
            {
                System.IO.Directory.CreateDirectory(TestGlobals.TEMP_DIR);
            }
        }

        ~DBProxy_UnitTest()
        {
            if (Directory.Exists(TestGlobals.TEMP_DIR) && Directory.GetFiles(TestGlobals.TEMP_DIR).Length == 0)
            {
                System.IO.Directory.Delete(TestGlobals.TEMP_DIR);
            }
        }

        private string createTempDB(SQLiteProxy db)
        {
            String dbName = TestGlobals.TEMP_DIR + (new Random()).Next(1000000, 10000000).ToString();

            Assert.DoesNotThrow(
                delegate
                {
                    db.Init(dbName, true);
                }
            );

            return dbName;
        }

        [Fact]
        [Trait("DBProxy Unit Tests", "Connect to existing DB")]
        /**
         *  <summary>
         *      Connects to existing database DB\patientData.db.
         *  </summary>
         */
        public void test1()
        {
            SQLiteProxy db = new SQLiteProxy();

            Assert.DoesNotThrow(
                delegate
                {
                    db.Init("Data" + System.IO.Path.DirectorySeparatorChar + "patientData");
                }
            );
        }

        [Fact]
        [Trait("DBProxy Unit Tests", "Connect to new DB (creates DB structure)")]
        /**
         *  <summary>
         *      Creates new DB, connects to it, adds structure and static data, and deletes the DB.
         *  </summary>
         */
        public void test2()
        {
            SQLiteProxy db = new SQLiteProxy();
            String dbName = createTempDB(db);

            try
            {
                System.IO.File.Delete(dbName + ".db");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Could not delete test DB (" + dbName +").");
            }
        }

        [Fact]
        [Trait("DBProxy Unit Tests", "Insert patient, health professional and visit (get)")]
        /**
         *  <summary>
         *      Inserts a patient a heath professional and a multiple visits. Verifies that they
         *      were all added and IDs where set correctly.
         *  </summary>
         */
        public void test3()
        {
            SQLiteProxy db = new SQLiteProxy();
            String dbName = createTempDB(db);

            Patient p = new Patient();
            HealthProfessional hp = new HealthProfessional();
            Visit v1 = null;
            Visit v2 = null;
            List<Visit> visits = null;

            Assert.DoesNotThrow(
                delegate
                {
                    db.InsertPatient(ref p);
                    db.InsertHealthProfessional(ref hp);

                    v1 = new Visit(p, hp, new DateTime(2011, 1, 1), new ProfessionalAct(2, 3), Rational.emergency);
                    v2 = new Visit(p, hp, new DateTime(2011, 12, 31), new ProfessionalAct(4, 5), Rational.checkup);
                    
                    db.InsertVisit(v1);
                    db.InsertVisit(v2);

                    visits = db.GetVisitsByPatient(p);
                }
            );

            Assert.Equal<long>(2, visits.Count);

            foreach (Visit v in visits)
            {
                Assert.True(v.Equals(v1) || v.Equals(v2));
            }

            try
            {
                System.IO.File.Delete(dbName + ".db");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Could not delete test DB.");
            }
        }
    }
}
