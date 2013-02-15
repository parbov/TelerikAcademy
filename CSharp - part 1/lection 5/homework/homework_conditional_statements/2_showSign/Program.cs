using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first real number");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Ënter second real number");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third real number");
        double thirdNum = double.Parse(Console.ReadLine());
        bool positive = true;

        if (firstNum == 0 && secondNum == 0 && thirdNum == 0)
        {
            Console.WriteLine("The product is 0 (zero)");
        }

        if (firstNum < 0)
        {
            positive = !positive;
        }

        if (secondNum < 0)
        {
            positive = !positive;
        }

        if (thirdNum < 0)
        {
            positive = !positive;
        }


        if (positive == true)
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
        else
        {
            Console.WriteLine("The sign of the product is \"-\"");
        }
    }
}

