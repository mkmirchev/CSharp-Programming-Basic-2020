using System;

namespace LenghtConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            float lenght = float.Parse(Console.ReadLine());
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (firstValue == "m" && secondValue =="mm")
            {
                Console.WriteLine("{0:F3}",lenght*1000);
            }
            else if (firstValue == "cm" && secondValue == "mm")
            {
                Console.WriteLine("{0:F3}", lenght * 10);
            }
            else if (firstValue == "m" && secondValue == "cm")
            {
                Console.WriteLine("{0:F3}", lenght * 100);
            }
            else if (firstValue == "cm" && secondValue == "m")
            {
                Console.WriteLine("{0:F3}", lenght / 100);
            }
            else if (firstValue == "mm" && secondValue == "m")
            {
                Console.WriteLine("{0:F3}", lenght / 1000);
            }
            else if (firstValue == "mm" && secondValue == "cm")
            {
                Console.WriteLine("{0:F3}", lenght / 10);
            }

        }
    }
}
