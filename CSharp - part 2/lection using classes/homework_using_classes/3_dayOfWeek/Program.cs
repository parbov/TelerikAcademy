using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_dayOfWeek
{
    class Program
    {
        static void Main()
        {
            DateTime today = DateTime.Today;

            Console.WriteLine(today.ToString("ddd"));
        }
    }
}
