using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_sequenceMaxSum
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
            int max = array[0], maxEnd = array[0];
            int longSequence = 1, currentSequence = 1;
            int start = 0, startTemp = 0;

            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i] + maxEnd > array[i])
                {
                    maxEnd = array[i] + maxEnd;
                    currentSequence++;
                }

                else
                {
                    maxEnd = array[i];
                    startTemp = i;
                    currentSequence = 1;
                }
                if (maxEnd > max)
                {
                    max = maxEnd;
                    longSequence = currentSequence;
                    start = startTemp;
                }
            }

            for (int i = start; i < start + longSequence; ++i)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
