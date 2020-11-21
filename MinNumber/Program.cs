using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                if (int.Parse(input) < minNumber)
                {
                    minNumber = int.Parse(input);
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
