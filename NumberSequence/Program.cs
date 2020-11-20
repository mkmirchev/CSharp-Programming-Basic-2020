using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int currentValue;
            int maxValue;
            int minValue;
            for (int i = 0; i < input; i++)
            {
                if (i==0)
                {
                    currentValue = int.Parse(Console.ReadLine());
                    maxValue = currentValue;
                    minValue = currentValue;
                }
                else if (i > 0)
                {
                    currentValue = int.Parse(Console.ReadLine());
                    if (currentValue>maxValue)
                    {
                        maxValue = currentValue;
                    }
                    else if (currentValue < minValue)
                    {
                        minValue = currentValue;
                    }
                }
                Console.WriteLine("Max "+maxValue);
                Console.WriteLine("Min "+minValue);
            }  
        }
    }
}
