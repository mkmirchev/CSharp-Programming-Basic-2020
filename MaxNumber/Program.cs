using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                if (int.Parse(input) > maxNumber)
                {
                    maxNumber = int.Parse(input);
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
