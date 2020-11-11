using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            switch (input)
            {
                case "Morning":
                    if (temperature >=0 && temperature <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";

                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (temperature >= 0 && temperature <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";

                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (temperature > 24)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if (temperature >= 0 && temperature <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";

                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;
                default:
                    break;
            }
            string output = "It's " + temperature + " degrees, get your " + outfit + " and " + shoes + ".";
            Console.WriteLine(output);
        }
    }
}
