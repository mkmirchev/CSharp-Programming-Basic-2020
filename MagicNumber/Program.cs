using System;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //gathering input values
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0; //counter for combinations;
            int magicCount = 0; //Row of magic combination 
            int magicOne = 0;
            int magicTwo = 0;
            bool isMagic = false; // bool value that gets the fist magic number
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int k = firstNumber; k <= secondNumber; k++)
                {
                    count++;
                    if (magicNumber == i+k && isMagic==false)
                    {
                        magicCount = count;
                        magicOne = i;
                        magicTwo = k;
                        isMagic = true;
                    }
                }
            }
            if (magicCount==0)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
            }
            else if (magicNumber > 0)
            {
                Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", magicCount, magicOne, magicTwo, magicNumber);
            }
        }
    }
}
