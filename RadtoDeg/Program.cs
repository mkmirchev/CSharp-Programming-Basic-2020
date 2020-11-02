using System;

namespace HelloSharp
{
    class Program1
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double output = input * 180 / Math.PI;
            Console.WriteLine(Math.Round(output));
        }
    }
}
