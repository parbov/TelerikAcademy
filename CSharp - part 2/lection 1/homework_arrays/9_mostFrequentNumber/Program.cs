using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_mostFrequentNumber
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
            //sort array

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

            //find the longest sequence of equal elements
            int element = array[0];
            int sequenceLength = 1;
            int sequenceStart = 0;
            int maxLength = 1;
            int maxLengthStart = 0;

            for (int j = 1; j < arrayLength; j++)
            {
                if (element == array[j])
                {
                    sequenceLength++;
                    sequenceStart = j - sequenceLength + 1;
                    if (maxLength < sequenceLength)
                    {
                        maxLength = sequenceLength;
                        maxLengthStart = sequenceStart;
                    }
                }
                else
                {
                    element = array[j];
                    sequenceLength = 1;
                }
            }
            Console.WriteLine("The most frequent number is: {0} ({1} times)",array[maxLengthStart],maxLength);
        }
    }
}
