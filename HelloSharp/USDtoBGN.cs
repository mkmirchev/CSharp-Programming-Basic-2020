using System;

namespace HelloSharp
{
    class Program
    { 
        static void Main(string[] args)
        {
            double usdToBGN = 1.79549;
            double input = double.Parse(Console.ReadLine());
            double convertedValue = input * usdToBGN;
            Console.WriteLine("{0:F2}",convertedValue);
         }
    }
}
