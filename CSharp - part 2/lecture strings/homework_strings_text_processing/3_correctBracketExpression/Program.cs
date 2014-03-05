using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_correctBracketExpression
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter expresion:");
            string input = Console.ReadLine();
            List<char> bracket = new List<char>();
            foreach (char item in input)
            {
                if (item == '(')
                {
                    bracket.Add(item);
                }
                else if (item == ')')
                {
                    if (bracket.Count > 0)
                    {
                        bracket.Remove('(');
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                        return;
                    }
                }
            }
            if (bracket.Count == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
