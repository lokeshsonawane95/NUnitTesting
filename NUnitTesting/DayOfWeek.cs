using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class DayOfWeek
    {
        public static void Day()
        {
            int m, d, y;
            Console.Write("Enter month : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day : ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year : ");
            y = Convert.ToInt32(Console.ReadLine());

            //Gregorian calendar logic
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            //We have index of the week day in d0 starting from 0 = Sunday to 6 = Saturday
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Day of the week is : " + days[d0]);
        }
    }
}
