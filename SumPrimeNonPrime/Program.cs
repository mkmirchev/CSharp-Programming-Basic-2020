using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int sumPrime = 0;
            int sumNonPrime = 0;
            bool isNotPrime = false;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else
                {
                int data = int.Parse(input);
                    if (data < 0)
                    {
                        Console.WriteLine("Number is negative.");
                    }
                    else
                    {
                        for (int i = 2; i <= data / 2; i++)
                        {
                            if (data % i == 0)
                            {
                                isNotPrime = true;
                                break;
                            }
                        }
                        if (isNotPrime == true)
                        {
                            sumNonPrime += data;
                        }
                        else
                        {
                            sumPrime += data;
                        }
                        isNotPrime = false;
                    }
                }
              
            }
            Console.WriteLine("Sum of all prime numbers is: {0}",sumPrime);
            Console.WriteLine("Sum of all non prime numbers is: {0}",sumNonPrime);
        }
    }
}

