using System;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fee = 0;
            int totalFee = 0;

            for (int i = 0; i < tabs; i++)
            {
                string site = Console.ReadLine();

                switch (site)
                {
                    case "Facebook": fee = 150; break;
                    case "Instagram": fee = 100; break;
                    case "Reddit": fee = 50; break;
                    default: fee = 0;
                        break;
                }

                totalFee += fee;
            }

            if(salary <= totalFee)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - totalFee);
            }
        }
    }
}