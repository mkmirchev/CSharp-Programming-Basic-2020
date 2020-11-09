using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double fruitPrice = 0;
            double totalPrice = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            fruitPrice = 2.5;
                            break;
                        case "apple":
                            fruitPrice = 1.2;
                            break;
                        case "orange":
                            fruitPrice = 0.85;
                            break;
                        case "grapefruit":
                            fruitPrice = 1.45;
                            break;
                        case "kiwi":
                            fruitPrice = 2.7;
                            break;
                        case "pineapple":
                            fruitPrice = 5.5;
                            break;
                        case "grapes":
                            fruitPrice = 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            fruitPrice = 2.7;
                            break;
                        case "apple":
                            fruitPrice = 1.25;
                            break;
                        case "orange":
                            fruitPrice = 0.9;
                            break;
                        case "grapefruit":
                            fruitPrice = 1.6;
                            break;
                        case "kiwi":
                            fruitPrice = 3;
                            break;
                        case "pineapple":
                            fruitPrice = 5.6;
                            break;
                        case "grapes":
                            fruitPrice = 4.2;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                    default:
                        Console.WriteLine("error");
                        break;
            }
            if (fruitPrice >0)
            {
                totalPrice = amount * fruitPrice;
                Console.WriteLine("{0:F2}", totalPrice);
            }
        }
            
        
    }
}
