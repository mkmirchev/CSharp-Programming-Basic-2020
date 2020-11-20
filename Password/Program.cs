using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string password = Console.ReadLine();
            string passInput;
            //Console.WriteLine("pass");
            while (true)
            {
                passInput = Console.ReadLine();
                if (password == passInput)
                {
                    Console.WriteLine("Welcome " + input +"!");
                    break;
                }
            }
        }
    }
}
