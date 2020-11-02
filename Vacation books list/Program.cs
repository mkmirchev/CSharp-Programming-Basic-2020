using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            float hourPerDay = (float)pages / (float)days / (float)pagesPerHour;
            Console.WriteLine(hourPerDay);

        }
    }
}
