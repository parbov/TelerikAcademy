using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_maxSequenceEqualElements
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
                    sequenceStart = j - sequenceLength+1;
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
            Console.WriteLine("The max sequence is:");
            for (int z = maxLengthStart; z < maxLengthStart+ maxLength; z++)
            {
                Console.Write(array[z]);
            }
        }
    }
}
