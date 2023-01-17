using System;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1Count = 0;
            double p2Count = 0;
            double p3Count = 0;
            double p4Count = 0;
            double p5Count = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number < 200)
                {
                    p1Count += 1;
                }
                else if(number >= 200 && number <= 399)
                {
                    p2Count += 1;
                }
                else if(number >= 400 && number <= 599)
                {
                    p3Count += 1;
                }
                else if(number >= 600 && number <= 799)
                {
                    p4Count += 1;
                }
                else if(number >= 800)
                {
                    p5Count += 1;
                }
            }

            double p1 = p1Count / n * 100;
            double p2 = p2Count / n * 100;
            double p3 = p3Count / n * 100;
            double p4 = p4Count / n * 100;
            double p5 = p5Count / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}