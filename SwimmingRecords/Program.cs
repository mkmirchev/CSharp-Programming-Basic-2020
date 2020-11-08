using System;

namespace SwimmingRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double swimmingSpeed = double.Parse(Console.ReadLine());
            double delay = Math.Floor(lenght / 15) * 12.5;
            double swimmingTime = lenght * swimmingSpeed + delay;
            if (worldRecord > swimmingTime)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", swimmingTime);
            }
            else 
            {
                double timeOverWorldRecord = swimmingTime - worldRecord;
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.",timeOverWorldRecord);
            }
        }
    }
}
