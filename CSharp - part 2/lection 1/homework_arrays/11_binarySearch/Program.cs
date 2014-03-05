using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_binarySearch
{
    class Program
    {
        static void Main()
        {
            int searchedNumber;
            Console.WriteLine("Please enter the number you are searching for:");
            searchedNumber = int.Parse(Console.ReadLine());

            int n;
            Console.WriteLine("Please enter your array lenght:");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Please enter your sorted array members:");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = 0;
            int max = arr.Length - 1;
            int middle = 0;

            while (min <= max)
            {
                middle = (max + min) / 2;

                if (arr[middle] < searchedNumber)
                {
                    min = middle + 1;
                }
                else if (arr[middle] > searchedNumber)
                {
                    max = middle - 1;
                }
                else
                {
                    break;
                }
            }

            if (arr[middle] == searchedNumber)
            {
                Console.WriteLine("The searched number {0} was found at index {1}", searchedNumber, middle);
            }
            else
            {
                Console.WriteLine("The number {0} you are searching for is not presented in the array.", searchedNumber);
            }
        }
    }
}
