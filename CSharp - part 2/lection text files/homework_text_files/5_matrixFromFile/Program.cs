using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5_matrixFromFile
{
    class Program
    {
        private static int FindMaxSum(int[,] matrix)
        {

            int bestSum = int.MinValue;
            int currentSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] +
                                 matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (bestSum < currentSum)
                    {
                        bestSum = currentSum;
                    }
                    currentSum = 0;
                }
            }
            return bestSum;
        }

        static void Main()
        {
            StreamReader read = new StreamReader("inputMatrix.txt");
            StreamWriter write = new StreamWriter("output.txt");
            string line = "";
            string number = "";
            int sizeOfMatrix;
            int row = 0;
            int col = 0;

            using (read)
            {
                // read size of matrix and make one with that size
                line = read.ReadLine();
                sizeOfMatrix = int.Parse(line);
                int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

                while ((line = read.ReadLine()) != null)
                {
                    // fills matrix with numbers
                    foreach (var symbol in line)
                    {
                        if (symbol != ' ')
                        {
                            number += symbol;
                        }
                        else
                        {
                            matrix[row, col] = int.Parse(number);
                            number = "";
                            col++;
                        }
                    }
                    matrix[row, col] = int.Parse(number);
                    col = 0;
                    row++;
                    number = "";
                }

                // print in file the max sum
                using (write)
                {
                    write.WriteLine(FindMaxSum(matrix));
                }
            }
        }
    }
}
