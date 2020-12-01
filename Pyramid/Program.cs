using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int colCounter = 0;
            int currentValue = 0;
            bool isDone = false;
            while (isDone == false)
            {
                for (int k = 0; k <= colCounter; k++)
                {
                    currentValue++;
                    Console.Write("{0} ", currentValue);
                    if (currentValue == a)
                    {
                        isDone = true;
                        break;
                    }
                }
                    colCounter++;
                Console.WriteLine();
            }
        }
    }
}
