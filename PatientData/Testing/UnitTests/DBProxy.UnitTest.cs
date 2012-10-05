using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace PatientData.Testing.UnitTesting
{
    using DB;

    public class DBProxy_UnitTest
    {
        public DBProxy_UnitTest()
        {
        }

        [Fact]
        [Trait("DBProxy Unit Tests", "Connect to existing DB")]
        /**
         *  <summary>
         *      
         *  </summary>
         */
        public void test1()
        {
            DBProxy db = new DBProxy();

            Assert.DoesNotThrow(
                delegate
                {
                    db.Init("DB" + System.IO.Path.DirectorySeparatorChar + "patientData");
                }
            );
        }

        [Fact]
        [Trait("DBProxy Unit Tests", "Connect to new DB (creates DB structure)")]
        /**
         *  <summary>
         *      
         *  </summary>
         */
        public void test2()
        {
            DBProxy db = new DBProxy();
            String dbName = (new Random()).Next(1000000, 10000000).ToString();

            Assert.DoesNotThrow(
                delegate
                {
                    db.Init(dbName, true);
                }
            );

            try
            {
                System.IO.File.Delete(dbName + ".db");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Could not delete test DB.");
            }
        }

        [Fact]
        [Trait("DBProxy Unit Tests", "Connect to new DB (creates DB structure)")]
        /**
         *  <summary>
         *      
         *  </summary>
         */
        public void test3()
        {
            DBProxy db = new DBProxy();
            String dbName = (new Random()).Next(1000000, 10000000).ToString();

            Assert.DoesNotThrow(
                delegate
                {
                    db.Init(dbName, true);
                }
            );

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
