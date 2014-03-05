using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_binaryToDecimal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a binary number:");
            string binary = Convert.ToString(Console.ReadLine());
            int decimalNumber = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                /*we get the bits from right to the left; if the number has '1' on position 31 (counting first position = 0), the decimal representation will be negative*/
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }
                decimalNumber += (int)Math.Pow(2, i);
                //we calculate the decimal number by the formula the bit*2^i
            }
            Console.WriteLine("The decimal representation of {0} is: {1}", binary, decimalNumber);
        }
    }
}
