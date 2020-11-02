using System;
using System.Globalization;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());
            double rspbrryPrice = strawberryPrice / 2;
            double banPrice = rspbrryPrice * 0.2;
            double orngsPrice = rspbrryPrice * 0.6;
            double totalSum = strawberries * strawberryPrice + bananas * banPrice + oranges * orngsPrice + raspberries * rspbrryPrice;
            Console.WriteLine(totalSum);
        }
    }
}
