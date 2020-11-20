using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double bankAccount = 0;
            double incraseAcc = 0;
            string end = "NoMoreMoney";
            string input = "0"; 
            while (input!= end)
            {
                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                incraseAcc = double.Parse(input);
                if (double.Parse(input)>0)
                {
                    Console.WriteLine("Increase: {0:F2}", incraseAcc);
                }            
                bankAccount += incraseAcc;
                input = Console.ReadLine();
            }
            Console.WriteLine("Total: {0:F2}",bankAccount);
        }
    }
}
