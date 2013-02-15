using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dividedInTheSameTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Int");
            int number = int.Parse(Console.ReadLine());
            bool canDivide = ((number % 5 == 0) && (number % 7 == 0));
            Console.WriteLine("The int can be divided by 7 and 5 at the same time: {0}",canDivide);
            {
            }
        }
    }
}
