using System;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > max)
                {
                    max = number;
                }

                
            }

            int sumWithout = sum - max;

            if(max == sumWithout)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWithout);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + diff);
            }
        }
    }
}