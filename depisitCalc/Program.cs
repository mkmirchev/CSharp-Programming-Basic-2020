using System;

namespace depisitCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            float amoung = float.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            float interest = float.Parse(Console.ReadLine())/100;
            double yearInterest = amoung * interest / 12;
            float totalSum = (float)amoung + (float)yearInterest*period;
            Console.WriteLine(totalSum);



        }
    }
}