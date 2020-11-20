using System;

namespace CharStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputLenght = input.Length;
            for (int i = 0; i < inputLenght; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
