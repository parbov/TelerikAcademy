using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_reversDigits
{
    class Program
    {
        static string NumberInReverse(int num)
        {
            StringBuilder reverseNumber = new StringBuilder();
            while (num != 0)
            {
                int lastDigit = num % 10;
                int lastNumber = num / 10;
                num = lastNumber;

                reverseNumber.Append(lastDigit);
            }

            return reverseNumber.ToString();
        }

        static void Main()
        {
            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberInReverse(number));
        }
    }
}
