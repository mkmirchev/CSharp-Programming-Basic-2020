using System;

namespace MinMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            int max = 0;
            int min = 0;
            int currentValue;
            for (int i = 0; i < inputNumbers; i++)
            {
                currentValue = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    max = currentValue;
                    min = max;
                }
                if (currentValue > max)
                {
                    max = currentValue;
                }
                else if (currentValue < min)
                {
                    min = currentValue;
                }
            }
            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Min number: " + min);

        }
    }
}
