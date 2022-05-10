using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class SquareRoot
    {
        public static void Root()
        {
            //Declaring constant epsilon
            const double epsilon = 1e-15;
            Console.Write("Enter a non-negative number to find sqare root : ");
            double c = Convert.ToInt32(Console.ReadLine());
            double t = c;
            if (c > 0)
            {
                //Square root calculation logic by Newton's method
                while (Math.Abs(t - c / t) > epsilon * t)
                {
                    //Console.WriteLine("Absolute value : " + (Math.Abs(t - c / t)) + " epsilon*t : " + (epsilon * t));
                    t = ((c / t) + t) / 2.0f;
                }
                Console.WriteLine("Square root by Newton's method is : " + t);
            }
            else
            {
                Console.WriteLine("Entered number is negative");
            }
        }
    }
}
