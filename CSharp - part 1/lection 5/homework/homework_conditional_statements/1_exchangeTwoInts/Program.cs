using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first int");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second int");
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            int temp = first;
            first = second;
            second = temp;
            Console.WriteLine("First int after exchange {0}",first);
            Console.WriteLine("Second int after exchange {0}",second);
        }
    }
}

