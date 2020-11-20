using System;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;
            int currentValue;
            int diff;
            for (int i = 0; i < n; i++)
            {
                currentValue = int.Parse(Console.ReadLine());
                sumOne += currentValue;

            }
            for (int i = 0; i < n; i++)
            {
                currentValue = int.Parse(Console.ReadLine());
                sumTwo += currentValue;

            }
            if (sumOne == sumTwo)
            {
                Console.WriteLine("Yes, sum = {0}",sumOne);
            }
            else
            {
                diff = sumOne - sumTwo;
                Console.WriteLine("No, diff = {0}", Math.Abs(diff));
            }
        }
    }
}
