using System;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0;
            double birthdayMoney = 0;
            double totalBirthdayMoney = 0;
            int toyCount = 0;
            double toySum = 0;

            for (int i = 1; i <= years; i++)
            {
                if(i % 2 == 0)
                {
                    birthdayMoney += 10;
                    totalBirthdayMoney += birthdayMoney - 1;
                }
                else
                {
                    toyCount += 1;
                }

                
            }

            toySum = toyCount * toyPrice;
            money = toySum + totalBirthdayMoney;

            if(money >= washingMachine)
            {
                Console.WriteLine($"Yes! {money - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - money:f2}");
            }
        }
    }
}