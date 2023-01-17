using System;

namespace numbers
{
    internal class Program
    {
        static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int index = 1; index <= numberCount; index++)
            {
                
                int firstNum = int.Parse(Console.ReadLine());
                leftSum += firstNum;
            }
            for (int index = 1; index <= numberCount; index++)
            {
                int secondNum = int.Parse(Console.ReadLine());
                rightSum += secondNum;
            }


            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}