using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideX = int.Parse(Console.ReadLine());
            int sideY = int.Parse(Console.ReadLine());
            int sideZ = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = (sideX * sideY * sideZ)*0.001;
            double tanksWater = volume * (1 - (percent * 0.01));
            Console.WriteLine(tanksWater);
        }
    }
}
