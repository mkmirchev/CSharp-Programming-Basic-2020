using System;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int evenSum=0;
            int oddSum=0;
            int currentValue;
            for (int i = 0; i < input; i++)
            {
                currentValue= int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentValue;
                }
                else
                {
                    oddSum += currentValue;
                }
            }
            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                int diff = evenSum - oddSum;
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(diff));
            }
        }
    }
}
