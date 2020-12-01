using System;

namespace EqualSumms
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int digitOne = 0;
            int digitTwo = 0;
            int digitThree = 0;
            int digitFour = 0;
            int digitFive = 0;
            int digitSix = 0;
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = a; i <= b; i++)
            {
                digitOne = i / 100000;
                digitTwo = (i / 10000) % 10;
                digitThree = (i / 1000) % 10;
                digitFour = (i / 100) % 10;
                digitFive= (i / 10) % 10;
                digitSix= i % 10;
                sumEven = digitTwo + digitFour + digitSix;
                sumOdd = digitOne + digitThree + digitFive;
                if (sumEven == sumOdd)
                {
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}
