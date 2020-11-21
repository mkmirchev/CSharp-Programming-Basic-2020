using System;

namespace OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string currentBook = "";
            int count = 0;
            while (true)
            {
                currentBook = Console.ReadLine();
                if (currentBook == "No More Books")
                {

                    Console.WriteLine("The book you searched is not here!");
                    Console.WriteLine("You have checked {0} books.", count);
                    break;
                }
                if (favouriteBook == currentBook)
                {
                    Console.WriteLine("You have checked {0} books and found it.",count);
                    break;
                }
                count++;
            }
        }
    }
}
