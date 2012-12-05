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

    public class SQLiteProxy_Test
    {
        #region Non-test
        public SQLiteProxy_Test()
        {
            if (!Directory.Exists(TestGlobals.TEMP_DIR))
            {
                System.IO.Directory.CreateDirectory(TestGlobals.TEMP_DIR);
            }
        }

        ~SQLiteProxy_Test()
        {
            if (Directory.Exists(TestGlobals.TEMP_DIR) && Directory.GetFiles(TestGlobals.TEMP_DIR).Length == 0)
            {
                System.IO.Directory.Delete(TestGlobals.TEMP_DIR);
            }
        }

        private string createTempDB(SQLiteProxy db)
        {
            String dbName = TestGlobals.TEMP_DIR + (new Random()).Next(1000000, 10000000).ToString() + ".db";

            Assert.DoesNotThrow(
                delegate
                {
                    db.Init(dbName, true);
                }
            );

            return dbName;
        }
        #endregion

        #region Tests
        [Fact]
        [Trait("SQLiteProxy", "1.1")]
        /**
         *  <summary>
         *      Connects to existing database DB\patientData.db.
         *  </summary>
         */
        public void ExistingDB()
        {
            SQLiteProxy db = new SQLiteProxy();

            Assert.DoesNotThrow(
                delegate
                {
                    db.Init("Data" + System.IO.Path.DirectorySeparatorChar + "patientData.db");
                }
            );
        }

        [Fact]
        [Trait("SQLiteProxy", "1.2")]
        /**
         *  <summary>
         *      Creates new DB, connects to it, adds structure and static data, and deletes the DB.
         *  </summary>
         */
        public void NewDB()
        {
            SQLiteProxy db = new SQLiteProxy();
            String dbName = createTempDB(db);

            try
            {
                System.IO.File.Delete(dbName + ".db");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Could not delete test DB (" + dbName + ").");
            }
        }

        [Fact]
        [Trait("SQLiteProxy", "3.1 - 3.3")]
        /**
         *  <summary>
         *      Inserts a patient a heath professional and a multiple visits. Verifies that they
         *      were all added and IDs where set correctly.
         *  </summary>
         */
        public void InsertTest()
        {
            SQLiteProxy db = new SQLiteProxy();
            String dbName = createTempDB(db);

            Patient p = new Patient();
            HealthProfessional hp = new HealthProfessional();
            Visit v = null;
            List<Visit> visits = null;

            Assert.Equal<long>(-1, p.UID);
            Assert.Equal<long>(-1, hp.UID);

            Assert.DoesNotThrow(
                delegate
                {
                    db.InsertPatient(ref p);
                    db.InsertHealthProfessional(ref hp);

                    v = new Visit(p, hp, new DateTime(2011, 1, 1), new ProfessionalAct(2, 3), Rational.emergency);

                    db.InsertVisit(v);

                    visits = db.GetVisitsByPatient(p);
                }
            );

            Assert.NotEqual<long>(-1, p.UID);
            Assert.NotEqual<long>(-1, hp.UID);

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
        [Trait("SQLiteProxy", "4.1 - 4.6")]
        /**
         *  <summary>
         *      Inserts a patient a heath professional and a multiple visits. Verifies that they
         *      were all added and IDs where set correctly.
         *  </summary>
         */
        public void GetTest()
        {
            SQLiteProxy db = new SQLiteProxy();
            String dbName = createTempDB(db);

            Patient p1 = new Patient();
            Patient p2 = new Patient();
            Patient p3 = new Patient();
            Patient p4 = null;
            HealthProfessional hp1 = new HealthProfessional();
            HealthProfessional hp2 = new HealthProfessional();
            Visit v1 = null;
            Visit v2 = null;
            Visit v3 = null;
            Visit v4 = null;
            Visit v5 = null;
            List<Visit> visits1 = null;
            List<Visit> visits2 = null;
            List<Visit> visits3 = null;

            List<Patient> patients = null;

            List<HealthProfessional> hps = null;

            Assert.Equal<long>(-1, p1.UID);
            Assert.Equal<long>(-1, p2.UID);
            Assert.Equal<long>(-1, p3.UID);

            Assert.Equal<long>(-1, hp1.UID);
            Assert.Equal<long>(-1, hp2.UID);

            Assert.DoesNotThrow(
                delegate
                {
                    db.InsertPatient(ref p1);
                    db.InsertPatient(ref p2);
                    db.InsertPatient(ref p3);
                    db.InsertHealthProfessional(ref hp1);
                    db.InsertHealthProfessional(ref hp2);

                    v1 = new Visit(p1, hp1, new DateTime(2011, 1, 1), new ProfessionalAct(2, 3), Rational.emergency);
                    v2 = new Visit(p1, hp2, new DateTime(2011, 1, 1), new ProfessionalAct(2, 3), Rational.checkup);
                    v3 = new Visit(p1, hp2, new DateTime(2011, 1, 1), new ProfessionalAct(2, 3), Rational.followUp);
                    v4 = new Visit(p1, hp2, new DateTime(2011, 1, 1), new ProfessionalAct(2, 3), Rational.initial);
                    v5 = new Visit(p2, hp2, new DateTime(2011, 1, 1), new ProfessionalAct(2, 3), Rational.initial);

                    db.InsertVisit(v1);
                    db.InsertVisit(v2);
                    db.InsertVisit(v3);
                    db.InsertVisit(v4);
                    db.InsertVisit(v5);

                    visits1 = db.GetVisitsByPatient(p1);
                    visits2 = db.GetVisitsByPatient(p2);
                    visits3 = db.GetVisitsByPatient(p3);

                    patients = db.GetPatients();

                    hps = db.GetHealthProfessionals();

                    p4 = db.GetPatientByID(100);
                }
            );

            Assert.NotEqual<long>(-1, p1.UID);
            Assert.NotEqual<long>(-1, p2.UID);
            Assert.NotEqual<long>(-1, p3.UID);

            Assert.NotEqual<long>(-1, hp1.UID);
            Assert.NotEqual<long>(-1, hp2.UID);

            Assert.Equal<long>(4, visits1.Count);
            Assert.Equal<long>(1, visits2.Count);
            Assert.Equal<long>(0, visits3.Count);

            Assert.Equal<long>(3, patients.Count);

            Assert.Equal<long>(2, hps.Count);

            Assert.Null(p4);

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
        [Trait("SQLiteProxy", "5.1 - 5.3")]
        public void GetACVs()
        {
            SQLiteProxy db = new SQLiteProxy();
            String dbName = createTempDB(db);

            List<Patient> ps = new List<Patient>();
            ps.Add(new Patient());
            ps.Add(new Patient());
            ps.Add(new Patient());

            List<HealthProfessional> hps = new List<HealthProfessional>();
            hps.Add(new HealthProfessional());

            Assert.DoesNotThrow(
                delegate
                {
                    Patient p;
                    for (int i = 0; i < ps.Count; i++)
                    {
                        p = ps.ElementAt<Patient>(i);
                        db.InsertPatient(ref p);
                    }
                    HealthProfessional hp;
                    for (int i = 0; i < hps.Count; i++)
                    {
                        hp = hps.ElementAt<HealthProfessional>(i);
                        db.InsertHealthProfessional(ref hp);
                    }
                }
            );

            List<Visit> vs = new List<Visit>();
            vs.Add(new Visit(
                ps.ElementAt<Patient>(0),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-01"),
                new ProfessionalAct(54, 12),
                Rational.initial));
            vs.Add(new Visit(
                ps.ElementAt<Patient>(0),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-02"),
                new ProfessionalAct(54, 12),
                Rational.initial));
            vs.Add(new Visit(
                ps.ElementAt<Patient>(0),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-03"),
                new ProfessionalAct(54, 12),
                Rational.initial));
            vs.Add(new Visit(
                ps.ElementAt<Patient>(0),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-04"),
                new ProfessionalAct(54, 12),
                Rational.initial));
            vs.Add(new Visit(
                ps.ElementAt<Patient>(1),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-05"),
                new ProfessionalAct(54, 12),
                Rational.initial));
            vs.Add(new Visit(
                ps.ElementAt<Patient>(2),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-06"),
                new ProfessionalAct(54, 12),
                Rational.initial));

            Assert.DoesNotThrow(
                delegate
                {
                    foreach (Visit v in vs)
                    {
                        db.InsertVisit(v);
                    }
                }

            );

            IEnumerable<IEnumerable<Visit>> acvs = db.GetACVs(ps.ElementAt<Patient>(0), 2);
            Assert.Equal<int>(6, acvs.Count<IEnumerable<Visit>>());
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(0), vs.ElementAt<Visit>(1) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(0), vs.ElementAt<Visit>(2) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(0), vs.ElementAt<Visit>(3) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(1), vs.ElementAt<Visit>(2) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(1), vs.ElementAt<Visit>(3) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(2), vs.ElementAt<Visit>(3) }, acvs);

            acvs = db.GetACVs(ps.ElementAt<Patient>(0), 3);
            Assert.Equal<int>(4, acvs.Count<IEnumerable<Visit>>());
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(0), vs.ElementAt<Visit>(1), vs.ElementAt<Visit>(2) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(0), vs.ElementAt<Visit>(1), vs.ElementAt<Visit>(3) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(0), vs.ElementAt<Visit>(2), vs.ElementAt<Visit>(3) }, acvs);
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(1), vs.ElementAt<Visit>(2), vs.ElementAt<Visit>(3) }, acvs);

            acvs = db.GetACVs(ps.ElementAt<Patient>(0), 4);
            Assert.Equal<int>(1, acvs.Count<IEnumerable<Visit>>());
            Assert.Contains<IEnumerable<Visit>>(new Visit[] { vs.ElementAt<Visit>(0), vs.ElementAt<Visit>(1), vs.ElementAt<Visit>(2), vs.ElementAt<Visit>(3) }, acvs);
        }
        #endregion
    }
}
