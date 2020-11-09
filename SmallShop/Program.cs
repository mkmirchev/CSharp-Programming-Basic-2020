using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.5;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "water")
                {
                    price = 0.8;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "beer")
                {
                    price = 1.2;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "peanuts")
                {
                    price = 1.6;
                    Console.WriteLine(quantity * price);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.4;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "water")
                {
                    price = 0.7;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "beer")
                {
                    price = 1.15;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "sweets")
                {
                    price = 1.3;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "peanuts")
                {
                    price = 1.5;
                    Console.WriteLine(quantity * price);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "water")
                {
                    price = 0.7;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "beer")
                {
                    price = 1.10;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                    Console.WriteLine(quantity * price);
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                    Console.WriteLine(quantity * price);
                }
            }
        }
    }
}
