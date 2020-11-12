using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int persons = int.Parse(Console.ReadLine());
            int rent = 0;
            double discount = 1;
            double bonusDiscount = 1;
            switch (season)
            {
                case "Autumn":
                    rent = 4200;
                    break;
                case "Summer":
                    rent = 4200;
                    break;
                case "Spring":
                    rent = 3000;
                    break;
                case "Winter":
                    rent = 2600;
                    break;
                default:
                    break;
            }
            if (persons <=6)
            {
                discount = 0.9;
            }
            else if (persons > 6 && persons <=11)
            {
                discount = 0.85;
            }
            else if (persons >11)
            {
                discount = 0.75;
            }
            if (season != "Autumn" && persons % 2 == 0)
            {
                bonusDiscount = 0.95;
            }
           double tripPrice = rent * discount * bonusDiscount;
            if (budget >= tripPrice)
            {
                double moneyLeft = budget - tripPrice;
                Console.WriteLine("Yes! You have {0:F2} leva left.",moneyLeft);
            }
            else if (budget < tripPrice)
            {
                double moneyNeeded = tripPrice - budget;
                Console.WriteLine("Not enough money! You need {0:F2} leva.",moneyNeeded);
            }
        }
    }
}
