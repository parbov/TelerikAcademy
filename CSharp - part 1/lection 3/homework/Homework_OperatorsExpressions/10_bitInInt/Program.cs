using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_bitInInt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter int");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> p;
            bool bitIsOne = (bit == 1);
            Console.WriteLine("v={0}  ; p={1}  ->{2}",number,p,bitIsOne);
        }
    }
}
