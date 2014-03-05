using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_selectionSort
{
    class Program
    {
        static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Unsorted array:");
            for (int count = 0; count < arrayLength; count++)
            {
                Console.Write(array[count] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sorted array: ");
            int min; 

            for (int z = 0; z < arrayLength; z++)
            {
                min = z;

                for (int j = z + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int exchangeValues = array[z];
                array[z] = array[min];
                array[min] = exchangeValues;

            }
            Console.WriteLine();
            for (int y = 0; y < arrayLength; y++)
            {
                Console.Write(array[y] + " ");
            }
        }
    }
}
