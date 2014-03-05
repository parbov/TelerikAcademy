using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_binSearch
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the length of the array N: ");
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);
            Console.Write("Enter the number K: ");
            string kStr = Console.ReadLine();
            int k = int.Parse(kStr);
            int[] arr = new int[n + 1];
            int m = 0, indexK;
            Console.WriteLine("Please enter the numbers of the array");
            while (m < n)
            {
                string numStr = Console.ReadLine();
                arr[m] = int.Parse(numStr);
                m++;
            }
            arr[n] = k;
            Array.Sort(arr, 0, n + 1);
            indexK = Array.BinarySearch(arr, k);
            if (indexK < n && arr[indexK] == arr[indexK + 1])
                Console.WriteLine(k);
            else if (indexK > 1)
                Console.WriteLine(arr[indexK - 1]);
            else
                Console.WriteLine("K is smaller than any number in the array");
            
        }
    }
}
