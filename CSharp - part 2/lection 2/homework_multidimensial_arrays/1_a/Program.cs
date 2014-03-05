using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_a
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter legth of the matrix nxn");
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int[,] array = new int[n, n];
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    array[row, col] = number++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ",array[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
