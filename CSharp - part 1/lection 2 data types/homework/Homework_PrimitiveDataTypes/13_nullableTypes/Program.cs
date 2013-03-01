using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_nullableTypes
{
    class Program
    {
        static void Main()
        {
            int? i = null;
            double? d = null;
            Console.WriteLine(i+4);
            Console.WriteLine(d+5.5);
            i = 4;
            Console.WriteLine(i);
            
        }
    }
}
