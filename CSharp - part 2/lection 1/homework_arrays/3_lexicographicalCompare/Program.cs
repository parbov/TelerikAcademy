using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lexicographicalCompare
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first char elements:");
            string firstChars = Console.ReadLine();
            char[] firstArray = firstChars.ToCharArray(); 
            int firstArrayLength = firstArray.Length;  

            Console.WriteLine("Please enter the second char elements:");
            string secondChars = Console.ReadLine();
            char[] secondArray = secondChars.ToCharArray();
            int secondArrayLength = secondArray.Length;

            int minLen = Math.Min(secondArrayLength, firstArrayLength); 

            bool equalArrays = true;  

            for (int i = 0; i < minLen; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                }
                else
                {
                    equalArrays = false;
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("The first char array is lexicografically before the second.");
                    }
                    else
                    {
                        Console.WriteLine("The second char array is lexicografically before the first.");
                    }
                    break;
                }
            }
            if (equalArrays == true && firstArrayLength < secondArrayLength)
            {
                Console.WriteLine("The first char array is lexicografically before the second.");
            }
            else if (equalArrays == true && firstArrayLength > secondArrayLength)
            {
                Console.WriteLine("The second char array is lexicografically before the first.");
            }
            else if (equalArrays == true && firstArrayLength == secondArrayLength)
            {
                Console.WriteLine("The arrays are equal.");
            }
        }
    }
}
