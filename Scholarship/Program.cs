using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double socialScholarship = Math.Floor(0.35 * minimalSalary);
            double excellentScoreScholarship = Math.Floor(25 * score);
            if (income > minimalSalary && score < 5.5 || income < minimalSalary && score < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalSalary && score > 4.5 && score < 5.5)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
            }
            else if (income > minimalSalary && score >= 5.5)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScoreScholarship);
            }
            else if (income <= minimalSalary && score >= 5.5)
            {
                if (excellentScoreScholarship >= socialScholarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScoreScholarship);
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
                }
            } 
        }
    }
}
