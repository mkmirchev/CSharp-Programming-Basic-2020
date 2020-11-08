using System;

namespace GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            float clothsPrice = float.Parse(Console.ReadLine());
            double decorPrice = budget * 0.1;
            double peoplePlusClothsPrice = people * clothsPrice;
            if (people > 150)
            {
                peoplePlusClothsPrice *= 0.9;
            }
            double moneyLeft = budget - decorPrice - peoplePlusClothsPrice;
            if (moneyLeft >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", moneyLeft);
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", Math.Abs(moneyLeft));
            }
        }
    }
}
