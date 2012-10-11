using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace PatientData.Testing.UnitTests
{
    using Data;
    using Entities;
    using Entities.Actors;

    public class Queries_UnitTest
    {
        public Queries_UnitTest()
        { }

        [Fact]
        [Trait("Query Unit Tests", "Get ACVs")]
        public void test1()
        {
            DBProxy db = new MemoryProxy();

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
                DateTime.Parse("2011-10-04"),
                new ProfessionalAct(54, 12),
                Rational.initial));
            vs.Add(new Visit(
                ps.ElementAt<Patient>(0),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-04"),
                new ProfessionalAct(54, 12),
                Rational.initial));
            vs.Add(new Visit(
                ps.ElementAt<Patient>(0),
                hps.ElementAt<HealthProfessional>(0),
                DateTime.Parse("2011-10-04"),
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

            Queries queries = new Queries(db);

            IEnumerable<IEnumerable<Visit>> acvs = queries.GetACVs(ps.ElementAt<Patient>(0), 2);
            Assert.Equal<int>(6, acvs.Count<IEnumerable<Visit>>());
        }
    }
}
