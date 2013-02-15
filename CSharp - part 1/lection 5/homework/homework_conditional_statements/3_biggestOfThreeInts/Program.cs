using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int maxNum = 0;
        Console.WriteLine("Enter first int");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second Int");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third int");
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                maxNum = firstNum;
            }
            else
            {
                maxNum = thirdNum;
            }
        }
        else
        {
            if (secondNum > thirdNum)
            {
                maxNum = secondNum;
            }
            else
            {
                maxNum = thirdNum;
            }
        }
        Console.WriteLine("The max int is: {0}",maxNum);
    }
}

