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
        Console.WriteLine("Enter second real number");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third real number");
        double thirdNum = double.Parse(Console.ReadLine());
        double max, mid, min;

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                max = firstNum;
                if (thirdNum > secondNum)
                {
                    mid = thirdNum;
                    min = secondNum;
                }
                else
                {
                    mid = secondNum;
                    min = thirdNum;
                }
            }
            else
            {
                max = thirdNum;
                mid = firstNum;
                min = secondNum;
            }
        }
        else
        {
            if (secondNum > thirdNum)
            {
                max = secondNum;
                if (firstNum > thirdNum)
                {
                    mid = firstNum;
                    min = thirdNum;
                }
                else
                {
                    mid = thirdNum;
                    min = firstNum;
                }
            }
            else
            {
                max = thirdNum;
                mid = secondNum;
                min = firstNum;
            }
        }
        Console.WriteLine("The descending order is: {0} {1} {2}",max,mid,min);
    }
}

