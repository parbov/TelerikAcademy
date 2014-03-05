using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_maximalIncreasingSequence
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
     //       int element = array[0];
            int sequenceStart = 0;
            int sequenceLength = 1;
            int maxLength = 1;
            int maxLengthStart = 0;
           
            for (int j = 0; j < arrayLength-1; j++)
            {
                if (array[j]+1 == array[j+1])
                {
                    sequenceLength++;
                    sequenceStart = j - sequenceLength + 2;
                    if (maxLength < sequenceLength)
                    {
                        maxLength = sequenceLength;
                        maxLengthStart = sequenceStart;
                    }
                }
                else
                {
    //                element = array[j];
                    sequenceLength = 1;
                }
            }
            Console.WriteLine("The max sequence is:");
            Console.Write("{ ");
            for (int z = maxLengthStart; z < maxLengthStart + maxLength; z++)
            {
                Console.Write("{0} ", array[z]);
            }
            Console.WriteLine("}");
        }
    }
}
