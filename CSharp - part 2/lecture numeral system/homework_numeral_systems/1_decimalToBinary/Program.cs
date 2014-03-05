using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_decimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());
            int numSys = 2;
            int remainder;
            int result;
            string numBin = "";

            remainder = number % numSys;
            result = number / numSys;
            numBin += remainder;

            while (result > 0)
            {
                remainder = result % numSys;
                result /= numSys;
                numBin += remainder;
            }

            numBin = new string(numBin.ToCharArray().Reverse().ToArray());
            Console.WriteLine("The Binary representation of given number\n n = {0} is: {1}", number, numBin);
        }
    }
}
