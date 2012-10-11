using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientData.Control
{
    static class UserInput
    {

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
                Console.Write(subject + " - please enter a date between " + lowerBound.ToString("dd-MM-yyyy") + " and " + upperBound.ToString("dd-MM-yyyy") + ": ");
                String strResult = Console.ReadLine();
                try
                {
                    result = DateTime.Parse(strResult);
                    if (result.CompareTo(lowerBound) >= 0 && result.CompareTo(upperBound) <= 0)
                    {
                        break;
                    }
                }
                catch (Exception x)
                {
                    if (strResult.Equals(""))
                    {
                        throw x;
                    }
                }
                Console.Write("Invalid date. ");
            }

            return result;
        }
    }
}
