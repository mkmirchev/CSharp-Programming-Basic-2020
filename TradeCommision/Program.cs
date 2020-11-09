using System;

namespace TradeCommision
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double commision = 0;
            switch (town)
            {
                case "Sofia":
                    if (0 <= sells && sells <=500)
                    {
                        commision = sells * 0.05;
                    }
                    else if (500 < sells && sells <= 1000)
                    {
                        commision = sells * 0.07;
                    }
                    else if (1000 < sells && sells <= 10000)
                    {
                        commision = sells * 0.08;
                    }
                    else if (sells > 10000)
                    {
                        commision = sells * 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;


                case "Varna":
                    if (0 <= sells && sells <= 500)
                    {
                        commision = sells * 0.045;
                    }
                    else if (500 < sells && sells <= 1000)
                    {
                        commision = sells * 0.075;
                    }
                    else if (1000 < sells && sells <= 10000)
                    {
                        commision = sells * 0.10;
                    }
                    else if (sells > 10000)
                    {
                        commision = sells * 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sells && sells <= 500)
                    {
                        commision = sells * 0.055;
                    }
                    else if (500 < sells && sells <= 1000)
                    {
                        commision = sells * 0.08;
                    }
                    else if (1000 < sells && sells <= 10000)
                    {
                        commision = sells * 0.12;
                    }
                    else if (sells > 10000)
                    {
                        commision = sells * 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (commision > 0)
            {
                Console.WriteLine("{0:F2}",commision);
            }
        }
    }
}
