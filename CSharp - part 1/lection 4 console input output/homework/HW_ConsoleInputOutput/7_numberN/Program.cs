using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_numberN
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 0;
            Console.WriteLine("Enter a number");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count;i++ )
            {
                Console.WriteLine("Enter value");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("The sum is: {0}",sum);
        }
    }
}
