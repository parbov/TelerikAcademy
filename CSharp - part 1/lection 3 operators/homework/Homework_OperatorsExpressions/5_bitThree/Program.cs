using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_bitThree
{
    class Program
    {
        static void Main()
        {
            int mask=8;  //8 is 00001000
            Console.WriteLine("Enter int");
            int number = int.Parse(Console.ReadLine());
           if ((number & mask) == 1)
            {
                Console.WriteLine("The third bit is 1");
            }
            else
            {
                Console.WriteLine("the third bit is 0");
            }
        }
    }
}
