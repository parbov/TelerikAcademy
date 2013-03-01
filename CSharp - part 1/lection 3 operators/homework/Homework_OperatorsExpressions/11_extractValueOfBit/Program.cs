using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_extractValueOfBit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter int");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("enter bit number");
            int b = int.Parse(Console.ReadLine());
           
            int mask = 1 << b;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> b;
            Console.WriteLine("int = {0} , bit number = {1} , value={2}",number,b,bit);


        }
    }
}
