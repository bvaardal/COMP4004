using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace PatientData.Testing.UnitTests
{
    using Entities;

    public class EntityObjects_UnitTest
    {
        public EntityObjects_UnitTest()
        {
        }

        [Fact]
        [Trait("Entity objects tests", "Create valid entity objects")]
        /**
         *  <summary>
         *      Creates instances of entity objects that do not have special conditions.
         *  </summary>
         */
        public void ValidEntityObjects()
        {
            Assert.DoesNotThrow(
                delegate
                {
                    new Patient();
                    new Patient(1);
                    new HealthProfessional();
                    new HealthProfessional(1);
                    new CMPair(new DateTime(2011, 01, 01), Rational.initial);
                    new ProfessionalAct(1, 1);
                    new Visit(new Patient(1), new HealthProfessional(1), new DateTime(2011, 01, 01), new ProfessionalAct(1, 1), Rational.initial);
                }
            );
        }

        [Fact]
        [Trait("Entity objects tests", "Create invalid entity objects")]
        /**
         *  <summary>
         *      Create invalid instances of entity objects. Expect InvalidParameterException.
         *  </summary>
         */
        public void InvalidEntityObjects()
        {
            Assert.Throws<InvalidParameterException>(
                delegate
                {
                    new HealthProfessional(200);
                }
            );

            Assert.Throws<InvalidParameterException>(
                delegate
                {
                    new ProfessionalAct(1000, 1);
                }
            );

            Assert.Throws<InvalidParameterException>(
                delegate
                {
                    new ProfessionalAct(1, 1000);
                }
            );

            Assert.Throws<InvalidParameterException>(
                delegate
                {
                    new Visit(new Patient(), new HealthProfessional(1), new DateTime(2011, 01, 01), new ProfessionalAct(1, 1), Rational.initial);
                }
            );

            Assert.Throws<InvalidParameterException>(
                delegate
                {
                    new Visit(new Patient(1), new HealthProfessional(), new DateTime(2011, 01, 01), new ProfessionalAct(1, 1), Rational.initial);
                }
            );

            Assert.Throws<InvalidParameterException>(
                delegate
                {
                    new Visit(new Patient(1), new HealthProfessional(), new DateTime(2010, 01, 01), new ProfessionalAct(1, 1), Rational.initial);
                }
            );
        }
    }
}
