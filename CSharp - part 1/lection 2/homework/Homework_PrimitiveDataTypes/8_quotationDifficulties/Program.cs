using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_quotationDifficulties
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = " the \"use\" of quotations causes difficulties";
            string str2 = @" the ""use"" of quotations causes difficulties";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
