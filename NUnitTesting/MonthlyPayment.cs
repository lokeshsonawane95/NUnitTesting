using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class MonthlyPayment
    {
        public static void Payment()
        {
            Console.Write("Enter Principle loan : ");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Years to pay off : ");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter percentage interest compounded monthly : ");
            double R = Convert.ToInt32(Console.ReadLine());

            //Given
            double n = 12 * Y;
            double r = R / (12 * 100);

            //Formula for conversion
            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("Monthly payment is : " + payment);
        }
    }
}
