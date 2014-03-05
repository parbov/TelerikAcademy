using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_allocateArray
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i] = i * 5;
            }
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine(array[j]);
            }
        }
    }
}
