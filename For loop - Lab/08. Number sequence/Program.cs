using System;

namespace numbers
{
    internal class Program
    {
        static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int index = 1; index <= numberCount; index++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");

            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}