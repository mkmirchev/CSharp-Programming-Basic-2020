using System;

namespace newHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double discount = 1;
            double flowerPrice = 0;
            switch (flower)
            {
                case "Roses":
                    flowerPrice = 5;
                    if (amount > 80)
                    {
                        discount = 0.9;
                    }
                    break;
                case "Dahlias":
                    flowerPrice = 3.80;
                    if (amount > 90)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Tulips":
                    flowerPrice = 2.8;
                    if (amount > 80)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Narcissus":
                    flowerPrice = 3;
                    if (amount < 120)
                    {
                        discount = 1.15;
                    }
                    break;
                case "Gladiolus":
                    flowerPrice = 2.5;
                    if (amount < 80)
                    {
                        discount = 1.2;
                    }
                    break;
                default:
                    break;
            }
            double moneyNeeded = amount * flowerPrice * discount;
            if (moneyNeeded <= budget)
            {
                double moneyLeft = budget - moneyNeeded;
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.",amount,flower,moneyLeft);
            }
            else if (moneyNeeded > budget)
            {
                double neededMoney = moneyNeeded - budget;
                Console.WriteLine("Not enough money, you need {0:F2} leva more.",neededMoney);
            }
        }
    }
}
