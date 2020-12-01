using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int a ;
            int b;
            int specialCount = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                a = i;
                for (int j = 0; j <= 3; j++)
                {
                    b = a %10;
                    if (b != 0 && input % b == 0)
                    {
                        specialCount++;
                    }
                        a /= 10;

                }
                if (specialCount == 4)
                {
                    specialCount = 0;
                    Console.Write("{0} ",i);
                }
                specialCount = 0;
            }
        }
    }
}
