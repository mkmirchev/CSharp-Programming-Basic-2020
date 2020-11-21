using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string currentPiece = "";
            int cakeSize = x * y;
            while (true)
            {
                currentPiece = Console.ReadLine();
                if (currentPiece == "STOP")
                {
                    Console.WriteLine("{0} pieces are left.",cakeSize);
                    break;
                }
                cakeSize -= int.Parse(currentPiece);
                if (cakeSize <= 0)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(cakeSize));
                    break;
                }
            }
        }
    }
}
