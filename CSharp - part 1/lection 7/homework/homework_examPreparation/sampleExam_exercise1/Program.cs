﻿using System;

namespace sampleExam_exercise1
{
    class Program
    {
        static void Main()
        {
 //           Console.WriteLine("Enter coordinate x=");
            decimal x = decimal.Parse(Console.ReadLine());
 //           Console.WriteLine("Enter coordinate Y=");
            decimal y = decimal.Parse(Console.ReadLine());

            if ((x == 0) && (y == 0))
            {
                Console.WriteLine(0);
            }
            else if ((x > 0) && (y > 0))
            {
                Console.WriteLine(1);
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine(2);
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine(3);
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine(4);
            }
            else if (x == 0)
            {
                Console.WriteLine(5);
            }
            else if (y == 0)
            {
                Console.WriteLine(6);
            }
        }
    }
}
