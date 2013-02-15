using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_sumWithAccuracy
{
    class Program
    {
        static void Main()
        {
            double newSum = 1 ;
            double eps = 0.001;  //eps za epsilong pri matemati4eskite iz4isleniq
            double i = 2;
            do
            {
                if (i % 2 == 0)
                {
                    newSum += (1 / i);
                }
                else
                {
                    newSum -= (1 / i);
                }
                i++;
            }while (Math.Abs(1 / i) >= eps);
            Console.WriteLine("{0:F3}",newSum);
        }
    }
}
