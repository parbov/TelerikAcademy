using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_indexOfFirstElementBiggerThanNeighbours
{
    class Program
    {
        static int BiggerNeighborFinder(int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;

        }
        static void Main()
        {
            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(BiggerNeighborFinder(array));
        }
    }
}
