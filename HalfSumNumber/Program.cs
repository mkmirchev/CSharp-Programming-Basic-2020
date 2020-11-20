using System;

namespace HalfSumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int maxNumber = 0; ;
            int sum = 0;
            int currentNumber;
            for (int i = 0; i < input; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber>maxNumber)
                {
                    maxNumber = currentNumber;
                }
                sum += currentNumber;
            }
            if ((sum - maxNumber) == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+maxNumber);
            }
            else
            {
                int diff = maxNumber - (sum - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " +Math.Abs(diff));
            }
        }
    }
}
