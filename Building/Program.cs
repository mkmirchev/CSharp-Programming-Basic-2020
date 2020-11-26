using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing input data
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = floor; i >= 1; i--)
            {
                for (int k = 0; k < rooms; k++)
                {
                    if (count == 0)
                    {
                        Console.Write("L{0}{1} ", i, k);
                        
                    }
                    else
                    {
                        if (i % 2 == 0 && count != 0)
                        {
                            Console.Write("O{0}{1} ", i, k);
                        }
                        else
                        {
                            Console.Write("A{0}{1} ", i, k);
                        }
                    }         
                }
                Console.WriteLine();
                count++;
            }    
        }
    }
}
