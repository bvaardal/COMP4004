using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PatientData
{
    using Control;

    class PatientData
    {
        private MatchTest mt;

        public void Run()
        {
            mt = new MatchTest(UserInput.getNumber("Create X patients for test", 10, 50));
            //UserInput.getDate("Create X patients for test", new DateTime(), new DateTime());
        }

        static void Main(string[] args)
        {
            (new PatientData()).Run();
        }
    }
}
