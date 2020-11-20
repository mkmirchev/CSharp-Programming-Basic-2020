using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            double p1 = 0.00; // 1 <= numbers < 200
            double p2 = 0.00; // 200<= numbers <=399
            double p3 = 0.00; // 400<= numbers <=599
            double p4 = 0.00; // 600<= numbers <=799
            double p5 = 0.00; // 800<= numbers <=1000
            for (int i = 0; i < input; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber >=1 && currentNumber < 200)
                {
                    p1++;
                }
                if (currentNumber >= 200 && currentNumber < 400)
                {
                    p2++;
                }
                if (currentNumber >= 400 && currentNumber < 600)
                {
                    p3++;
                }
                if (currentNumber >= 600 && currentNumber < 800)
                {
                    p4++;
                }
                if (currentNumber >= 800 && currentNumber <= 1000)
                {
                    p5++;
                }
            }
            Console.WriteLine("{0:F2}%", p1/input * 100.00);
            Console.WriteLine("{0:F2}%", p2/input * 100.00);
            Console.WriteLine("{0:F2}%", p3/input * 100.00);
            Console.WriteLine("{0:F2}%", p4/input * 100.00);
            Console.WriteLine("{0:F2}%", p5/input * 100.00);
        }
    }
}
