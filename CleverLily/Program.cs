using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysYears = int.Parse(Console.ReadLine());
            double washingMaschinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double money = 0;
            double totalMoney = 0;
            int toysCount = 0;
            int count = 0;
            for (int i = 1; i <= lilysYears; i++)
            {
                
                if (i%2==0)
                {
                    money +=10+(10*count);
                    count++;
                    //Console.WriteLine("Brother get :{0}", count);
                    //Console.WriteLine("Money :{0}", money);

                }
                else
                {
                    toysCount++;
                    //Console.WriteLine("Toys:{0}", toysCount);
                }    
            }
            totalMoney = toysPrice * toysCount + money - count;
            //Console.WriteLine(totalMoney);
            if (totalMoney >= washingMaschinePrice)
            {
                double moneyLeft = totalMoney - washingMaschinePrice;
                Console.WriteLine("Yes! {0:F2}", moneyLeft);
            }
            else
            {
                double moneyNeeded = washingMaschinePrice - totalMoney;
                Console.WriteLine("No! {0:F2}", moneyNeeded);
            }
        }
    }
}
