using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_matrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter int<20");
            int n = int.Parse(Console.ReadLine());

            if ((n <= 0) || (n > 20))
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j <= n + i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
