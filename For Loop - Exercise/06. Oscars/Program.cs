using System;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyScore = double.Parse(Console.ReadLine());
            int judgesCount = int.Parse(Console.ReadLine());
            double totalPoints = academyScore;

            for (int i = 1; i <= judgesCount; i++)
            {
                string judge = Console.ReadLine();
                double score = double.Parse(Console.ReadLine());
                double points = (judge.Length * score) / 2;
                academyScore += points;

                if(academyScore >= 1250.5)
                {
                    break;
                }
            }

            if(academyScore >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {academyScore:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - academyScore:f1} more!");
            }
        }
    }
}