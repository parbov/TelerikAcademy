using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_stringAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "Hello";
            string secondStr = "World";
            object obj = firstStr + " " + secondStr;
            string thirdStr = (string)obj;

            Console.WriteLine(obj);
            Console.WriteLine(thirdStr);
        }
    }
}
