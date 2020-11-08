using System;

namespace Petya_sShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int count = a + b + c + d + e;
            double totalMoney = a * 2.6 + a * 3 + a * 4.1 + a * 8.2 + a * 2;
            double output;
            double moneyBalance;
            if (count >= 50)
            {
                double moneyAfterDiscount = totalMoney * 0.75;
                output = moneyAfterDiscount * 0.9;
            }
            else
            {
                output = totalMoney * 0.9;
            }
            if (vacationPrice <= output)
            {
                moneyBalance = output - vacationPrice;
                Console.WriteLine("Yes! {0} lw left.", moneyBalance);
            }
            else
            {
                moneyBalance = vacationPrice - output;
                Console.WriteLine("Not enough money! {0} lv needed.", moneyBalance);
            }
        }
    }
}
    
