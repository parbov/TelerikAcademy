using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_stringArrSortByLength
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the elements of the string arrays separated by \",\":");
            string[] stringArray = Console.ReadLine().Split(',');
            Console.WriteLine();
            SortStringArray(ref stringArray);
            Console.WriteLine("The sorted string is:");
            for (int i = 0; i < stringArray.Length - 1; i++)
            {
                Console.Write("{0},", stringArray[i]);
            }
            Console.WriteLine("{0}", stringArray[stringArray.Length - 1]);
        }

        private static void SortStringArray(ref string[] stringArray)
        {
            int[] lengthArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                lengthArray[i] = stringArray[i].Length;
            }
            Array.Sort(lengthArray, stringArray);
            return;
        }
    }
}
