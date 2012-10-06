using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace PatientData.Testing.UnitTests
{
    using Entities;
    using Entities.Actors;

    public class EntityObjects_UnitTest
    {
        public EntityObjects_UnitTest()
        {
        }

        [Fact]
        [Trait("Entity objects unit tests", "Create entity objects")]
        /**
         *  <summary>
         *      Creates instances of entity objects that do not have special conditions.
         *  </summary>
         */
        public void test1()
        {
        }

        [Fact]
        [Trait("Entity objects unit tests", "Create visit")]
        /**
         *  <summary>
         *      Creates instance of Visit. Attempts invalid date.
         *  </summary>
         */
        public void test2()
        {
        }

        [Fact]
        [Trait("Entity objects unit tests", "Create professional act")]
        /**
         *  <summary>
         *      Creates instance of ProfessionalAct. Attempts invalid OHPA and diagnosis.
         *  </summary>
         */
        public void test3()
        {
        }
    }
}
