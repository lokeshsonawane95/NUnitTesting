using System;

namespace NUnitTesting
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. Find day of week");
                Console.WriteLine("2. Temperature conversion");
                Console.WriteLine("3. Monthly payment");
                Console.WriteLine("4. Square root by Newton's method");

                Console.WriteLine("0. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DayOfWeek.Day();
                        break;
                    case 2:
                        TemperatureConversion.Conversion();
                        break;
                    case 3:
                        MonthlyPayment.Payment();
                        break;
                    case 4:
                        SquareRoot.Root();
                        break;
                }
            } while (choice != 0);
        }
    }
}