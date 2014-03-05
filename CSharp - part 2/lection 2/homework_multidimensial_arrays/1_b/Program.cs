using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentValue = 1;
            int[,] matrix = new int[n, n];
            for (int cols = 0; cols < n; cols++)
            {
                if (cols % 2 == 0)
                {
                    for (int rows = 0; rows < n; rows++)
                    {
                        matrix[rows, cols] = currentValue++;
                    }
                }
                else
                {
                    for (int rows = n - 1; rows >= 0; rows--)
                    {
                        matrix[rows, cols] = currentValue++;
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
