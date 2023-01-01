using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Leapyear
    {
        public static void leap()
        {
            Console.WriteLine("Enter the year and check the year is leaf year or not");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year > 999) && (year < 10000))
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("This Year is leap year");
                }
                else if ((year % 4 == 0) && (year % 100 != 0))
                {
                    Console.WriteLine("This year is leap year");
                }
                else
                {
                    Console.WriteLine("This year is not leap year");
                }
            }
            else
            {
                Console.WriteLine("enter a valid year");

            }
        }
    }
}
