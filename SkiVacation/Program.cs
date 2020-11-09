using System;

namespace SkiVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int duration = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            int overnight = duration - 1;
            double discount = 0;
            double overnightPricePerNight = 0;
            double totalPriceAfterDiscount = 0;
            switch (room)
            {
                case "room for one person":
                    overnightPricePerNight = 18;
                    totalPriceAfterDiscount = overnightPricePerNight * overnight;
                    break;
                case "apartment":
                    if (overnight < 10)
                    {
                        discount = 1 - 0.3;
                    }
                    else if (10 <= overnight && overnight <= 15)
                    {
                        discount = 1- 0.35;
                    }
                    else if (overnight > 15)
                    {
                        discount = 1 - 0.5;
                    }
                    overnightPricePerNight = 25;
                    totalPriceAfterDiscount = overnightPricePerNight * overnight * discount;
                    break;
                case "president apartment":
                    if (overnight < 10)
                    {
                        discount = 1- 0.1;
                    }
                    else if (10 <= overnight && overnight <= 15)
                    {
                        discount = 1- 0.15;
                    }
                    else if (overnight > 15)
                    {
                        discount = 1- 0.2;
                    }
                    overnightPricePerNight = 35;
                    totalPriceAfterDiscount = overnightPricePerNight * overnight * discount;
                    break;
                default:
                    break;
            }
            if (grade == "positive" )
            {
                totalPriceAfterDiscount = Math.Round(totalPriceAfterDiscount* 1.25,2);
            }
            else if (grade == "negative")
            {
                totalPriceAfterDiscount = Math.Round(totalPriceAfterDiscount * 0.9,2);
            }
            Console.WriteLine("{0:F2}",totalPriceAfterDiscount);
        }
    }
}
