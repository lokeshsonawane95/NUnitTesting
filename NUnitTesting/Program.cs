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
                Console.WriteLine("\n1. Find day of week");
                Console.WriteLine("2. Temperature conversion");
                Console.WriteLine("3. Monthly payment");
                Console.WriteLine("4. Square root by Newton's method");
                Console.WriteLine("5. Decimal to binary conversion");
                Console.WriteLine("6. Binary Nibble Swap");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
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
                    case 5:
                        Console.Write("Enter a decimal number to convert into binary : ");
                        int number = Convert.ToByte(Console.ReadLine());
                        DecimalToBinary.ToBinary(number);
                        break;
                    case 6:
                        NibbleSwap nibbleSwap = new NibbleSwap();
                        nibbleSwap.Swap();
                        break;
                }
            } while (choice != 0);
        }
    }
}