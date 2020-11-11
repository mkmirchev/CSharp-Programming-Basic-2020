using System;
using System.Data.Common;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string cinemaType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colunms = int.Parse(Console.ReadLine());
            int cinemaCapacity = rows * colunms;
            double ticketPrice = 0.0;
            switch (cinemaType)
            {
                case "Premiere":
                    ticketPrice = 12.0;
                    break;
                case "Normal":
                    ticketPrice = 7.5;
                    break;
                case "Discount":
                    ticketPrice = 5.0;
                    break;
                default:
                    break;
            }
            double totalIncome = (double)cinemaCapacity * ticketPrice;
            Console.WriteLine("{0:F2} leva", totalIncome);
        }
    }
}
