using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            string middle = elements[(left + right) / 2];
            while (i <= j)
            {
                while (elements[i].CompareTo(middle) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(middle) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
