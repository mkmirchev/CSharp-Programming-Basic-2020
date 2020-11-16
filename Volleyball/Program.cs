using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double volleyballDays = ((48-h)*0.75)+h+(p * 2.0 / 3);
            if (yearType == "leap")
            {
                volleyballDays *= 1.15;
            }
            Console.WriteLine("{0:F0}",Math.Floor(volleyballDays));
        }
    }
}
