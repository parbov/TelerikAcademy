using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = n - 1;
            int y = 0;
            int[,] matrix = new int[n, n];
            for (int currentValue = 1; currentValue <= n * n; currentValue++)
            {
                matrix[x++, y++] = currentValue;

                if (x == n || y == n)
                {
                    x--;
                    if (y == n)
                    {
                        x--;
                        y--;
                    }
                    while (x - 1 >= 0 && y - 1 >= 0)
                    {
                        x--;
                        y--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
