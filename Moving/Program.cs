using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int totalSpace = x * y * z;
            int volumeCounter = 0;
            string luggage = "";
            while (true)
            {
                luggage = Console.ReadLine();
                if (luggage == "Done")
                {                           
                    Console.WriteLine("{0} Cubic meters left.",totalSpace);
                    break;
                }
                if (0 >= totalSpace)
                {
                    Console.WriteLine("No more free space! You need {0} Cubic meters more.",Math.Abs(totalSpace));
                    break;
                }
                totalSpace -= int.Parse(luggage);
            }
        }
    }
}
