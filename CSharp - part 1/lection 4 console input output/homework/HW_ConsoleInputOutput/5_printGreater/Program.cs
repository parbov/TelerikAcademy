using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_printGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The greater is {0}",Math.Max(firstNumber,secondNumber));
        }
    }
}
