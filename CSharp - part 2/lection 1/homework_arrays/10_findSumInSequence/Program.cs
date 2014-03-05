using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_findSumInSequence
{
    class Program
    {
        static void Main()
        {
            int i = 0, j = 0, k = 0, NumOfSums = 0, sum = 0, start = 0, end = 0;
            Console.WriteLine("Enter the length of the array N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sum S:");
            int S = int.Parse(Console.ReadLine());
            int[] Arr = new int[N];
            for ( i = 0; i < N; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i + j < N)                 
                    {
                        sum = sum + Arr[i + j];   
                        if (sum == S)                
                        {
                            start = i;              
                            end = i + j;            
                            NumOfSums++;            
                            Console.Write("\nTimes the sum is present: ");
                            for (k = start; k <= end; k++)
                            {
                                Console.Write("{0}; ", Arr[k]);
                            }
                        }
                    }
                }
                sum = 0;  
            }
            Console.Write("\n sum number is: {0}\n", NumOfSums);
            
        }
    }
}
