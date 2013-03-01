using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_twoPositiveInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = 0;
            Console.WriteLine("Enter first int:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second int:");
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber;i++ )
            {
                if (i % 5 == 0)
                {
                    countNumbers++;
                }
            }
            Console.WriteLine("count of the numbers is: {0}",countNumbers);
        }
    }
}
