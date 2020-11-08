using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting players times from console
            int time = 0;
            int hours = 0;
            int minutes = 0;
            for (int i = 0; i < 3; i++)
            {
                int playerTime = int.Parse(Console.ReadLine());
                time += playerTime;
            }
            //calculate hours and minutes from total time
            hours = time / 60;
            minutes = time % 60;
            //generating output
            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
