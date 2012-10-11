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
            mt = new MatchTest();
            mt.Init(UserInput.getNumber("Create X patients for test", 10, 50));

            bool cmCreated = false;

            while (true)
            {
                /* Print menu */
                Console.WriteLine("");
                Console.WriteLine("-=MENU=-");
                Console.WriteLine(" 1) Create CM");
                if (cmCreated)
                {
                    Console.WriteLine(" 2) Report matching ACVs");
                }

                int menuOption = UserInput.getNumber("Choose menu option", 1, cmCreated ? 2 : 1);

                switch (menuOption)
                {
                    case 1:
                        createCM();
                        cmCreated = true;
                        break;
                    case 2:
                        mt.PrintACVs(mt.GetMatchingACVs(UserInput.getNumber("Patient ID", 1, 50)));
                        break;
                    default:
                        break;
                }

                //UserInput.getDate("Create X patients for test", new DateTime(), new DateTime());
            }
        }

        private void createCM()
        {
            mt.ClearCM();
            Console.WriteLine("Input up to five {Date, Rational} pairs. Input blank Date to end CM input.");
            for (int i = 0; i < 5; i++)
            {
                DateTime dt;
                try
                {
                     dt = UserInput.getDate("Input date", new DateTime(2011, 01, 01), new DateTime(2011, 12, 31));
                }
                catch (Exception)
                {
                    break;
                }
                int r = UserInput.getNumber("Input rational", 1, 5);
                mt.AddCM(dt, r);
            }
        }

        static void Main(string[] args)
        {
            (new PatientData()).Run();
        }
    }
}
