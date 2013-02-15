using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AgeAfterYears
{
    class PrintAge
    {
        static void Main()
        {
            int age = 0;
            Console.WriteLine("Write your age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: {0}",age+10);
        }
    }
}
