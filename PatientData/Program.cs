﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PatientData
{
    using Control;
    using GUI;

    class Program
    {
        //private TestData mt;

        public void Run()
        {
            /*
            mt = new MatchTest();
            mt.Init(UserInput.getNumber("Create X patients for test", 10, 50));

            bool cmCreated = false;

            while (true)
            {*/
                /* Print menu */
                /*Console.WriteLine("");
                Console.WriteLine("-=MENU=-");
                Console.WriteLine(" 1) Create CM");
                Console.WriteLine(" 2) Get patient ACVs");
                if (cmCreated)
                {
                    Console.WriteLine(" 3) Report matching ACVs");
                }
                Console.WriteLine(" 0) Exit");

                int menuOption = UserInput.getNumber("Choose menu option", 0, cmCreated ? 3 : 2);

                switch (menuOption)
                {
                    case 1:
                        createCM();
                        cmCreated = true;
                        break;
                    case 2:
                        mt.PrintPatientACVs(UserInput.getNumber("Patient ID", 1, 50), UserInput.getNumber("Tuple size", 1, 5));
                        break;
                    case 3:
                        mt.PrintACVs(mt.GetMatchingACVs(UserInput.getNumber("Patient ID", 1, 50)));
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }

                //UserInput.getDate("Create X patients for test", new DateTime(), new DateTime());
            }*/
        }

        [STAThread]
        static void Main(string[] args)
        {
            //(new PatientData()).Run();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainWindow());
            new PatientDataController();
        }
    }
}
