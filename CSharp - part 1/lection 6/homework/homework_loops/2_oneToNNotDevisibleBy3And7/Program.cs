using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oneToNNotDevisibleBy3And7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number N");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
