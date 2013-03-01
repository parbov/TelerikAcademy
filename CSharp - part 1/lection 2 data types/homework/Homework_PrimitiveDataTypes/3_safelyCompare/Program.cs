using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_safelyCompare
{
    class Program
    {
        private static bool Compare(decimal a, decimal b)
        {
            decimal difference = 0.000001M;
            if (Math.Abs(a - b) < difference)
            {
                return (true);
            }
            else 
                return (false);
        }
         

        static void Main()
        {
            Console.WriteLine("Write the first number:");
            decimal firstNumber = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number:");
            decimal secondNumber = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("The comparison of {0} and {1} is {2}",firstNumber,secondNumber,Compare(firstNumber,secondNumber)); ;
        }

     
    }
}
