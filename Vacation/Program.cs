using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            string spend = "spend";
            string save = "save";
            string input = "";
            double currentSum = 0;
            int daysCount = 1;
            int spendDaysCount = 0;
            while (true)
            {
                input = Console.ReadLine();
                if(input == spend)
                {
                    currentSum = double.Parse(Console.ReadLine());
                    currentMoney -= currentSum;
                    spendDaysCount++;
                    if (currentMoney <=0)
                    {
                        currentMoney = 0;
                    }
                    if (spendDaysCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                }
                if (input == save)
                {
                    currentSum = double.Parse(Console.ReadLine());
                    currentMoney += currentSum;
                    spendDaysCount = 0;
                    if (currentMoney >= vacationPrice)
                    {
                        Console.WriteLine("You saved the money for {0} days.",daysCount);
                        break;
                    }
                }
                daysCount++;
            }
        }
    }
}
