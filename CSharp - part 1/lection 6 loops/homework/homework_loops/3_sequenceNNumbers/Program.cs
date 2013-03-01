using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_sequenceNNumbers
{
    class Program
    {
        static void Main()
        {
            //            int min = 0;
            //            int max = 0;
            Console.WriteLine("Enter number N");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter integers");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum is {0}", min);
            Console.WriteLine("Maximum is {0}", max);
        }
    }
}
