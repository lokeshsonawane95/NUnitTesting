using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class TemperatureConversion
    {
        public static void Conversion()
        {
            Console.WriteLine("Enter Choice");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter temperature in degree Celsius : ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                //Celsius to Fahrenheit conversion formula
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine("Temperature in degree Fahrenheit is : " + fahrenheit + " degree Fahrenheit");
            }
            else
            {
                Console.Write("Enter temperature in degree Fahrenheit : ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                //Fahrenheit to Celsius conversion formula
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Temperature in degree Celsius is : " + celsius + " degree Celsius");
            }
        }
    }
}
