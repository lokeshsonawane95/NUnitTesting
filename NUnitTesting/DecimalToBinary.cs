using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class DecimalToBinary
    {
        public static void ToBinary()
        {
            int[] binaryNumber = new int[32];
            Console.Write("Enter a decimal number to convert into binary : ");
            int number = Convert.ToByte(Console.ReadLine());
            int i = 0;
            Console.Write("Binary representation of " + number + " is : ");

            //Decimal to binary conversion logic
            while (number > 0)
            {
                binaryNumber[i] = number % 2;
                number /= 2;
                i++;
            }

            //We are printing the array in reverse to get the binary representation
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryNumber[j]);
            }
        }
    }
}
