using System;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (100 > a)
            {
                Console.WriteLine("Less than 100");
            }
            else if (200 < a)
            {
                Console.WriteLine("Greater than 200");
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
