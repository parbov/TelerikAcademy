using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    if (i == 0)
                    {
                        if (j < n) { Console.Write("."); } else { Console.Write("*"); }
                    }
                    else if (i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == (2 * n) - 1) { Console.Write("*"); }
                        else if (j == n - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
