using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine("{0:F3}",area);
            }
            else if (input == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (a * b);
                Console.WriteLine("{0:F3}", area);
            }
            else if (input == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a*Math.PI;
                Console.WriteLine("{0:F3}", area);
            }
            else if (input == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (a * b) / 2;
                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}
