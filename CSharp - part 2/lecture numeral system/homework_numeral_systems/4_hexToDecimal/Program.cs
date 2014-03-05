using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_hexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> Binary = new List<char>();
            string Bin = Console.ReadLine();
            char[] Binr=Bin.ToCharArray();
            for (int i = 0; i < Binr.Length; i++)
            {
                Binary.Add(Binr[i]);
            }
            double dec = 0;
            double br = Binary.Count-1;
            foreach (char item in Binary)
            {
              int num;
              if (item == 'A' || item == 'a') num = 10;
                else if (item == 'B'||item=='b') num = 11;
                else if (item == 'C' || item == 'c') num = 12;
                else if (item == 'D' || item == 'd') num = 13;
                else if (item == 'E' || item == 'e') num = 14;
                else if (item == 'F' || item == 'f') num = 15;
                else num=item-'0';
                dec += num*(Math.Pow(16, br));
                br--;
            }
            Console.WriteLine("Decimal:" + dec);
        }
    }
}
