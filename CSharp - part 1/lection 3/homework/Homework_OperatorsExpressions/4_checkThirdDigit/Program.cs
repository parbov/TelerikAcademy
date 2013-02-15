using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_checkThirdDigit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Int");
            int number = int.Parse(Console.ReadLine());
            bool isSeven = ((number / 100) % 10 == 7);
            Console.WriteLine("The third digit (right-to-left) is seven: {0}",isSeven);
        }
    }
}
