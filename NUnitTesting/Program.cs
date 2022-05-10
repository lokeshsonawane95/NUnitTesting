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

                Console.WriteLine("0. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DayOfWeek.Day();
                        break;
                }
            } while (choice != 0);
        }
    }
}