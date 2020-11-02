using System;

namespace CharityCampain
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cheffs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int goffretes = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double dailyamount = (cakes * 45 + goffretes * 5.80 + pancakes * 3.20)*cheffs;
            double totalamount = dailyamount * days;
            double charitySum = totalamount - (totalamount / 8);
            Console.WriteLine("{0:F2}",charitySum);
        }
    }
}
