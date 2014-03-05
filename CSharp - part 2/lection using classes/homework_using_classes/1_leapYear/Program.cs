using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort year = ushort.Parse(Console.ReadLine());
            bool isleap = DateTime.IsLeapYear(year);
            Console.WriteLine("Is {0} leap year?  {1}", year, isleap);
        }
    }
}
