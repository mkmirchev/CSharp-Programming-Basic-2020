using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double currentNumber;
            for (int i = 1; i <= input; i++)
            {
                currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }

                }
                else
                {
                    oddSum += currentNumber;
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                }
            }
            Console.WriteLine("OddSum={0:F2},", oddSum);
            if (input==0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");

            }
            else
            {
                Console.WriteLine("OddMin={0:F2},", oddMin);
                Console.WriteLine("OddMax={0:F2},", oddMax);
            }
            Console.WriteLine("EvenSum={0:F2},", evenSum);
            if (input == 1 || input == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");

            }
            else
            {
                Console.WriteLine("EvenMin={0:F2},", evenMin);
                Console.WriteLine("EvenMax={0:F2}", evenMax);
            }
        }
    }
}
