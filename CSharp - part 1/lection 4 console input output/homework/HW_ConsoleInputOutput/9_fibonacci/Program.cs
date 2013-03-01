using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_fibonacci
{
    class Program
    {
        static void Main()
        {
            decimal firstNumber =0;
            decimal secondNumber = 1;
            decimal temp =0;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            for (int i = 0; i < 100;i++ )
            {
                temp = firstNumber + secondNumber;
                Console.WriteLine(temp);
                firstNumber = secondNumber;
                secondNumber = temp;
            }
        }
    }
}
