﻿using System;
using System.Globalization;

namespace sequense
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = new int[4];
            Console.Write("Input 1st sequence number:");
            seq[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd sequence number:");
            seq[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 3rd sequence number:");
            seq[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 4th sequence number:");
            seq[3] = Convert.ToInt32(Console.ReadLine());
            if (seq[3] > seq[2] && seq[2] > seq[1] && seq[1] > seq[0])
            {
                Console.WriteLine("Sequence is icrasing");
            }
            else
            {
                Console.WriteLine("Sequence is decreasing");
            }
        }
    }
}
