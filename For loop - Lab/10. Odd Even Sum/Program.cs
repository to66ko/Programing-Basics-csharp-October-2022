using System;

namespace numbers
{
    internal class Program
    {
        static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int index = 1; index <= numberCount; index++)
            {
                int number = int.Parse(Console.ReadLine());

                if(index % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            if(evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }

        }
    }
}