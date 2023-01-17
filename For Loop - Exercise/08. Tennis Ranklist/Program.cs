using System;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int points = 0;
            int pointsSum = startingPoints;
            double averagePoints = 0;
            double tournamentsWon = 0;
            

            for (int i = 1; i <= tournamentsCount; i++)
            {
                string tournamentStage = Console.ReadLine();

                switch (tournamentStage)
                {
                    case "W": points = 2000; break;
                    case "F": points = 1200; break;
                    case "SF": points = 720; break;
                }

                pointsSum += points;

                averagePoints += points;

                if(tournamentStage == "W")
                {
                    tournamentsWon += 1;
                }
            }

            averagePoints /= tournamentsCount;

            double percent = (tournamentsWon / tournamentsCount) * 100;

            Console.WriteLine($"Final points: {pointsSum}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}