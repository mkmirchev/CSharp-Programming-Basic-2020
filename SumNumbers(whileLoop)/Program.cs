using System;

namespace SumNumbers_whileLoop_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b;
            int sum=0;
            while (true)
            {
                b = int.Parse(Console.ReadLine());
                sum += b;
                if (sum >= a)
                {
                    break; 
                }
            }
        }
    }
}
