using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_frequenceOfNumberInArray
{
    class Program
    {
        public static int FrequenceOfNumberInArray(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }
            Console.WriteLine("The number {0} appears {1} times",number,counter);
            return 0;
        }
        static void Main()
        {
            Console.WriteLine("Enter length of array");
            int arrLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrLength];
            for (int i = 0; i <arrLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter wanted number");
            int number = int.Parse(Console.ReadLine());
            FrequenceOfNumberInArray(array, number);
        }
    }
}
