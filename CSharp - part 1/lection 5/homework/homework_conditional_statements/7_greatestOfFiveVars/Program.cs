using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_greatestOfFiveVars
{
    class Program
    {

        static void Main()
        {
            int max = 0;
            int[] Arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter value of var[{0}]=", i);
                Arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            Console.WriteLine("The greatest is: {0}", max);
        }
    }
}
