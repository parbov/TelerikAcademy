using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_reversedString
{
    class Program
    {
        static void Main()
        {
            string enteredString = Console.ReadLine();
            StringBuilder reversedString= new StringBuilder();
            for (int i = enteredString.Length-1   ; i >=0; i--)
            {
                reversedString.Append(enteredString[i]);
            }
            Console.WriteLine(reversedString);
        }
    }
}
