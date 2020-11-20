using System;

namespace _2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int nextNumber = 0;
            while (true)
            {
                nextNumber = nextNumber * 2 + 1;
                if (input <= nextNumber)
                {
                    if (input==nextNumber)
                    {
                        Console.WriteLine(nextNumber);
                    }
                    break;
                }
                Console.WriteLine(nextNumber);
            }
        }
    }
}
