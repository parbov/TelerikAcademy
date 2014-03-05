using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_isElementBiggerThanNeighbours
{
    class Program
    {
        public static int IsElementBiggerThanNeighbours(int[] array, int position)
        {
            if (position >= array.Length)
            {
                Console.WriteLine("Element is not Present");
            }
            else
            {
                if ((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
                {
                    Console.WriteLine("The element in this position is bigger than its neighbours");
                }
                else
                {
                    Console.WriteLine("The element is not bigger than its neighbours");
                }
                
            }
            return 0;
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
            Console.WriteLine("Enter wanted position");
            int enteredPosition = int.Parse(Console.ReadLine());
            IsElementBiggerThanNeighbours(array, enteredPosition);
        }
    }
}
