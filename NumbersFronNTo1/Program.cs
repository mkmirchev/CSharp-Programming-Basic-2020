using System;

namespace NumbersFronNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = input; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
