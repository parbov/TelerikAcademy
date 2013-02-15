using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_numbersInInterval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
