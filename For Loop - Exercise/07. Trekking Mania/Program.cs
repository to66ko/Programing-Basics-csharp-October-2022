using System;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int musalaClimbers = 0;
            int monblanClimbers = 0;
            int kilimandjaroClimbers = 0;
            int k2Climbers = 0;
            double everestClimbers = 0;
            double totalClimbers = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                int climbersCount = int.Parse(Console.ReadLine());

                if (climbersCount <= 5)
                {
                    musalaClimbers += climbersCount;
                }
                else if (climbersCount >= 6 && climbersCount <= 12)
                {
                    monblanClimbers += climbersCount;
                }
                else if (climbersCount >= 13 && climbersCount <= 25)
                {
                    kilimandjaroClimbers += climbersCount;
                }
                else if (climbersCount >= 26 && climbersCount <= 40)
                {
                    k2Climbers += climbersCount;
                }
                else if (climbersCount >= 41)
                {
                    everestClimbers += climbersCount;
                }

                totalClimbers += climbersCount;
            }

            double musala = musalaClimbers / totalClimbers * 100;
            double monblan = monblanClimbers / totalClimbers * 100;
            double kilimandjaro = kilimandjaroClimbers/ totalClimbers * 100;
            double k2 = k2Climbers/ totalClimbers * 100;
            double everest = everestClimbers/ totalClimbers * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}