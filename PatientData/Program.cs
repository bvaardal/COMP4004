using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PatientData
{
    class Program
    {
        private MatchTest mt;

        public void Run()
        {
            mt = new MatchTest(getNumber("Patients", 10, 50));
        }

        /**
         * 
         */
        public static int getNumber(String subject, int lowerBound, int upperBound)
        {
            int result = -1;

            while (true)
            {
                Console.Write(subject + " - please enter a number between " + lowerBound + " and " + upperBound + ": ");
                String strResult = Console.ReadLine();
                try
                {
                    result = Int32.Parse(strResult);
                    if (result >= lowerBound && result <= upperBound)
                    {
                        break;
                    }
                }
                catch (Exception)
                { }
                Console.Write("Invalid number. ");
            }

            return result;
        }

        static void Main(string[] args)
        {
            (new Program()).Run();

            /*
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }
            IEnumerable<IEnumerable<int>> c = Helpers.TupleGenerator.Combinations<int>(list, 5);
            */
        }
    }
}
