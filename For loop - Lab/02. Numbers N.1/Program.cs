﻿using System;

namespace numbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}