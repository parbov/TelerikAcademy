using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_rectangularMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            while (n <= 3)
            {
                Console.WriteLine("Enter n of matrix NxM");
                n = int.Parse(Console.ReadLine());
            }
            while (m <= 3)
            {
                Console.WriteLine("Enter m of matrix NxM");
                m = int.Parse(Console.ReadLine());
            }
            int[,] array = new int[n, m];

            //enter elements
            Console.WriteLine("Enter elements");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    array[row, col] = int.Parse(Console.ReadLine());
                }
            }
            // find squares 3x3
            int tempSum = 0;
            int maxSum = 0;
            int rowStart = 0;
            int colStart = 0;

            for (int row = 0; row <= n-3; row++)
            {
                for (int col = 0; col <= m-3; col++)
                {
                    tempSum = array[row, col] + array[row, col+1] + array[row, col+2] + array[row+1, col] + array[row+1, col+1] + array[row+1, col+2] + array[row+2, col] + array[row+2, col+1] + array[row+2, col+2];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        rowStart = row;
                        colStart = col;
                    }
                }
            }

            // print result
            Console.WriteLine("The max sum is {0} in 3x3:",maxSum);
            for (int i = rowStart; i < rowStart+3; i++)
            {
                for (int j = colStart; j < colStart+3; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
