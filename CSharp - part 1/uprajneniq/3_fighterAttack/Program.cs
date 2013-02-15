﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_fighterAttack
{
    class Program
    {
        static void Main()
        {
            int px1 = int.Parse(Console.ReadLine());
            int py1 = int.Parse(Console.ReadLine());
            int px2 = int.Parse(Console.ReadLine());
            int py2 = int.Parse(Console.ReadLine());
            int fx = int.Parse(Console.ReadLine());
            int fy = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            // Find the plant bounds
            int minX = Math.Min(px1, px2);
            int maxX = Math.Max(px1, px2);
            int minY = Math.Min(py1, py2);
            int maxY = Math.Max(py1, py2);

            // Find the hit points
            int hitX = fx + d;
            int hitY = fy;
            int hitUpX = hitX;
            int hitUpY = hitY - 1;
            int hitDownX = hitX;
            int hitDownY = hitY + 1;
            int hitRightX = hitX + 1;
            int hitRightY = hitY;

            // Calculate the damage over the plant
            int totalDamage = 0;
            if (hitX >= minX && hitX <= maxX && hitY >= minY && hitY <= maxY)
            {
                totalDamage += 100;
            }
            if (hitUpX >= minX && hitUpX <= maxX && hitUpY >= minY && hitUpY <= maxY)
            {
                totalDamage += 50;
            }
            if (hitDownX >= minX && hitDownX <= maxX && hitDownY >= minY && hitDownY <= maxY)
            {
                totalDamage += 50;
            }
            if (hitRightX >= minX && hitRightX <= maxX && hitRightY >= minY && hitRightY <= maxY)
            {
                totalDamage += 75;
            }

            // Print the damage
            Console.WriteLine(totalDamage + "%");
        }
    }
}
