using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input >= 100 && input <= 200 || input == 0)
            {
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
