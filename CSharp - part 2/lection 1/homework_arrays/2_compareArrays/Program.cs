using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_compareArrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter length of first array:");
            int firstArrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("enter length of second array");
            int secondArrayLength = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstArrayLength];
            int[] secondArray = new int[secondArrayLength];
            bool equal = true;
            if (firstArrayLength != secondArrayLength)
            {
                equal = false;
                Console.WriteLine("The arrays are not equal due to different numbers of elements");
            }
            else
            {
                Console.WriteLine("Enter elements of first array");
                for (int i = 0; i < firstArrayLength; i++)
                {
                    firstArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("enter elements of second array");
                for (int j = 0; j < secondArrayLength; j++)
                {
                                       secondArray[j] = int.Parse(Console.ReadLine());
 
                }
                for (int z = 0; z < firstArrayLength; z++)
                {
                    if (firstArray[z] != secondArray[z])
                    {
                        equal = false;
                        break;
                    }
                }
                Console.WriteLine("The arrays are equal: {0}",equal);
            }
        }
    }
}
