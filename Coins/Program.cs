using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int sum = (int)(input * 100);
            int count = 0;
            int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 };
            for (int i = 0; i < 8; i++)
            {
                count += sum / coins[i];
                sum = sum % coins[i];
            }
            Console.WriteLine(count);
        }
    }
}

