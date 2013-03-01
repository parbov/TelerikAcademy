using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_switchUserChoise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your input choice: 1) int  2)double  3) string");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter var");
                        int input = int.Parse(Console.ReadLine());
                        Console.WriteLine("The result is {0}",++input);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter var");
                        double number = double.Parse(Console.ReadLine());
                        Console.WriteLine("The result is {0}",++number);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter var");
                        string strInput = Console.ReadLine();
                        Console.WriteLine(strInput+"*");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input error"); break;
                    }
            }
            
           
        }
    }
}
