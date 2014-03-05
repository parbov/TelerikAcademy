﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_binaryToHex
{
    class Program
    {
        static string BinToHex(string bin)
        {
            string hex = "";
            int remainder = bin.Length % 4;
            if (remainder != 0)
            {
                bin = bin.PadLeft(((bin.Length / 4) + 1) * 4, '0');
            }
            for (int i = 0; i < bin.Length; i += 4)
            {
                string fourByFour = bin.Substring(i, 4);
                hex += string.Format("{0:X}", Convert.ToByte(fourByFour, 2));
            }
            return hex.ToString();
        }
        static void Main()
        {
            string bin = Console.ReadLine();
            string hex = BinToHex(bin);
            Console.WriteLine(hex);
        }
    }
}
