using System;

namespace DivideWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            double p1 = 0.00; // number%2==0
            double p2 = 0.00; // number%3==0
            double p3 = 0.00; // number%4==0
            for (int i = 0; i < input; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    p1++;
                }
                if (currentNumber % 3 == 0)
                {
                    p2++;
                }
                if (currentNumber % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:F2}%", p1 / input * 100.00);
            Console.WriteLine("{0:F2}%", p2 / input * 100.00);
            Console.WriteLine("{0:F2}%", p3 / input * 100.00);
        }
    }
}
