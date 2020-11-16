using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double apartmentPrice = 0;
            double roomPrice = 0;
            double discountRoom = 1;
            double apartmentDiscount = 1;
            double vacationPriceForApartment = 0;
            double vacationPriceForRoom = 0;
            switch (input)
            {
                case "May":
                case "October":
                    roomPrice = 50;
                    apartmentPrice = 65;
                    if (days > 7 && days <= 14)
                    {
                        discountRoom = 1-0.05;
                    }
                    else if (days > 14)
                    {
                        discountRoom = 1-0.3;
                    }
                    break;

                case "June":
                case "September":
                    roomPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (days > 14)
                    {
                        discountRoom = 1 - 0.2;           
                    }
                    break;

                case "July":
                case "August":
                    roomPrice = 76.0;
                    apartmentPrice = 77.0;
                    break;
                default:
                    break;
            }
            if (days>14)
            {
                apartmentDiscount = 1 - 0.1;
            }
            vacationPriceForApartment = days * apartmentPrice * apartmentDiscount;
            vacationPriceForRoom = days * roomPrice * discountRoom;
            Console.WriteLine("Apartment: {0:F2} lv.",vacationPriceForApartment);
            Console.WriteLine("Studio: {0:F2} lv.",vacationPriceForRoom);
        }
    }
}
