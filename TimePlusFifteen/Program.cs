using System;

namespace TimePlusFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesAfterFifteen = minutes + 15;
            if (minutesAfterFifteen > 59)
            {
                minutesAfterFifteen %= 60;
                hours += 1;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine("{0}:{1:D2}",hours,minutesAfterFifteen);
        }
    }
}
