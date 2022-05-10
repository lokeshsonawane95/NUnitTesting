using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class NibbleSwap
    {
        public void Swap()
        {
            Console.Write("Enter a decimal number for nibble swap operation : ");
            int number = Convert.ToInt32(Console.ReadLine());
            DecimalToBinary.ToBinary(number);

            //1. Nibble swap logic
            int swappedNumber = (number & 0x0F) << 4 | (number & 0xF0) >> 4;
            Console.WriteLine("\nNew number after nibble swap is : " + swappedNumber);

            //2. Checking if the new number after nibble swap is power of 2 or not
            bool powerOfTwo = (int)(Math.Ceiling((Math.Log(swappedNumber) / Math.Log(2)))) ==
                (int)(Math.Floor((Math.Log(swappedNumber) / Math.Log(2))));
            if (powerOfTwo)
            {
                Console.WriteLine("The " + swappedNumber + " is power of 2");
            }
            else
            {
                Console.WriteLine("The " + swappedNumber + " is not a power of 2");
            }
        }
    }
}
