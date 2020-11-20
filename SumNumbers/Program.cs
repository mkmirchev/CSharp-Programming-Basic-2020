using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                int currentValue = int.Parse(Console.ReadLine());
                sum += currentValue;
            }
            Console.WriteLine(sum);
        }    
    }
}
