using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_methodPrintName
{
    class Program
    {
        public static void PrintName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}",name);
            return;
        }
        static void Main()
        {
            PrintName();
        }
    }
}
