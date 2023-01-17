using System;

namespace numbers
{
    internal class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int index = 1; index < numbersCount; index++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}