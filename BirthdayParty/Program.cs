using System;
using System.Globalization;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePrice = rent * 0.2;
            double drinks = cakePrice * 0.55;
            double animator = rent / 3;
            double totalSum = cakePrice + drinks + animator+rent;
            Console.WriteLine(totalSum);
        }
    }
}
