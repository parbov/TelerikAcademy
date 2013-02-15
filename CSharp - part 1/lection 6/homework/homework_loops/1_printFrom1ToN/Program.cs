using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_printFrom1ToN
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number N");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
