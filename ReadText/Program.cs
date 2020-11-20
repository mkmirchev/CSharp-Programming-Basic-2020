using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = "Stop";
            string currentWord = "";
            while (true)
            {
                currentWord = Console.ReadLine();
                if (currentWord == stop)
                {
                    break;
                }
                Console.WriteLine(currentWord);
            }
        }
    }
}
