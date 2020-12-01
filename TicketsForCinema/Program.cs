using System;

namespace TicketsForCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = "";
            string ticketType = "";
            int visitors = 0;
            int currentMovieTickets = 0;
            int allMovies = 0;
            int allmoviesTickets = 0;
            int kidTicketCount = 0;
            int studentTicketCount = 0;
            int standartTicketCount = 0;
            bool end = false;
            while (end == false)
            {
                movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                visitors = int.Parse(Console.ReadLine());
                for (int i = 1; i <= visitors; i++)
                {
                    ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "Finish")
                    {
                        end = true;
                        break;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketCount++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTicketCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartTicketCount++;
                    }
                    currentMovieTickets++;
                    allmoviesTickets++;
                }
                Console.WriteLine("{0} - {1:F2}% full.", movieName, (currentMovieTickets*100.0) / visitors);
                currentMovieTickets = 0;
            }
            Console.WriteLine("Total tickets: {0}", allmoviesTickets);
            Console.WriteLine("{0:F2}% student tickets.", (studentTicketCount * 100.0) / allmoviesTickets);
            Console.WriteLine("{0:F2}% standard tickets.", (standartTicketCount * 100.0) / allmoviesTickets);
            Console.WriteLine("{0:F2}% kids tickets.", (kidTicketCount * 100.0) / allmoviesTickets);
        }
    }
}
