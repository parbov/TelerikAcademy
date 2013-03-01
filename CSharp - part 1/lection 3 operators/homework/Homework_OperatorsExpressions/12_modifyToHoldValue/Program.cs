using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_modifyToHoldValue
{
    class Program
    {
        static void Main()
        {
            int v = 3;
            Console.WriteLine("Enter int");
            int number = int.Parse(Console.ReadLine());
            while ((v <0) || (v > 1))
            {
                Console.WriteLine("Enter value 0/1");
                v = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter position");
            int p = int.Parse(Console.ReadLine());
        
            string beforeChanges = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine(beforeChanges);
            if (v == 0)
            {
                int mask = ~(1 << p);
                int result = number & mask;
                string resultIfZero = Convert.ToString(result, 2).PadLeft(32, '0');
                Console.WriteLine("After changes ={0} ", resultIfZero);
            }
            else
            {
                int maskIfOne = 1 << p;
                int resultNMask = (number | maskIfOne);
                string resultIfOne = Convert.ToString(resultNMask, 2).PadLeft(32, '0');
                Console.WriteLine("After changes = {0}", resultIfOne);
            }

        }
    }
}
