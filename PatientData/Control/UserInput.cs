using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Control
{
    static class UserInput
    {
        public static void Output(String s)
        {
            Console.Write(s);
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

        /**
         * 
         */
        public static DateTime getDate(String subject, DateTime lowerBound, DateTime upperBound)
        {
            DateTime result = new DateTime();

            while (true)
            {
                Console.Write(subject + " - please enter a date between " + lowerBound.ToString("DD-MM-YYYY") + " and " + upperBound.ToString("DD-MM-YYYY") + ": ");
                String strResult = Console.ReadLine();
                try
                {
                    result = DateTime.Parse(strResult);
                    if (result.CompareTo(lowerBound) >= 0 && result.CompareTo(upperBound) <= 0)
                    {
                        break;
                    }
                }
                catch (Exception)
                { }
                Console.Write("Invalid date. ");
            }

            return result;
        }
    }
}
