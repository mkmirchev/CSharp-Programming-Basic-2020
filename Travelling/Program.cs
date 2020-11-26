using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double innerInput = 0;
            double budget = 0;

            while (true)
            {
                double save = 0;
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                budget = double.Parse(Console.ReadLine());
                while (true)
                {
                    if (save >= budget)
                    {
                        break;
                    }
                    innerInput = double.Parse(Console.ReadLine());
                    save += innerInput;

                }
                Console.WriteLine($"Going to {input}!");
            }
        }
    }
}
