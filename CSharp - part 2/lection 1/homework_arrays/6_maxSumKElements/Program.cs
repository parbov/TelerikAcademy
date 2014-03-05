using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_maxSumKElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            string bestSeq = "";
            int sum = 0;
            int bestSum = int.MinValue;
            int arrayLen = array.Length;
            for (int i = 0; i < arrayLen; i++)
            {
                string currentSeq = "";
                if (i + k > arrayLen)
                {
                    break;
                }
                for (int j = i; j < i + k; j++)
                {
                    sum = sum + array[j];
                    currentSeq = currentSeq + ' ' + array[j];
                }
                if (sum > bestSum)
                {
                    bestSeq = currentSeq;
                    bestSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine(bestSeq);
            Console.WriteLine(bestSum);
        }
    }
}
