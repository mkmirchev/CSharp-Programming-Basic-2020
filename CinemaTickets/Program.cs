using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int ticketPrice = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    ticketPrice = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    ticketPrice = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    ticketPrice = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(ticketPrice);
        }
    }
}
