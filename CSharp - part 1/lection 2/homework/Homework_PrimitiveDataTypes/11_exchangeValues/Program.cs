using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_exchangeValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp;
            Console.WriteLine("Before A={0} B={1}",a,b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After A={0}, B={1}",a,b);
        }
    }
}
