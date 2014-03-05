using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_fromBaseSToBaseD
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of the system from which you want to convert number s = :");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the system to which you want to convert number d = :");
            int d = int.Parse(Console.ReadLine());

            //convert from s system to decimal system by Horner scheme
            Console.Write("Enter the number you want to convert:");
            string numberS = Console.ReadLine();
            int number = ConvertToDecimal(s, numberS);


            //convert from decimal to d system

            number = ConvertFromDecimalToDsystem(d, number);

        }

        private static int ConvertFromDecimalToDsystem(int d, int number)
        {
            List<char> dSystem = new List<char>();
            while (number > 0)
            {
                int k = number > d ? (number % d) : number;
                switch (k)
                {
                    case 0: dSystem.Add('0'); break;
                    case 1: dSystem.Add('1'); break;
                    case 2: dSystem.Add('2'); break;
                    case 3: dSystem.Add('3'); break;
                    case 4: dSystem.Add('4'); break;
                    case 5: dSystem.Add('5'); break;
                    case 6: dSystem.Add('6'); break;
                    case 7: dSystem.Add('7'); break;
                    case 8: dSystem.Add('8'); break;
                    case 9: dSystem.Add('9'); break;
                    case 10: dSystem.Add('A'); break;
                    case 11: dSystem.Add('B'); break;
                    case 12: dSystem.Add('C'); break;
                    case 13: dSystem.Add('D'); break;
                    case 14: dSystem.Add('E'); break;
                    case 15: dSystem.Add('F'); break;
                }
                number = number / d;

            }
            for (int i = dSystem.Count - 1; i >= 0; i--)
            {
                Console.Write(dSystem[i]);
            }
            Console.WriteLine();
            return number;
        }

        private static int ConvertToDecimal(int s, string numberS)
        {
            int number = int.Parse(numberS[0].ToString());
            for (int i = 1; i < numberS.Length; i++)
            {
                number = s * number + int.Parse(numberS[i].ToString());
            }
            Console.WriteLine(number);
            return number;
        }
    }
}
