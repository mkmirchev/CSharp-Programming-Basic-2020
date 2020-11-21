using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = 1;
            double grades = 0;
            int lowScoreCount = 0;
            double gradesSum = 0;
            while (true)
            {
                grades = double.Parse(Console.ReadLine());
                gradesSum += grades;
                if (grades < 4)
                {
                    lowScoreCount++;
                }
                if (lowScoreCount == 2)
                {
                    Console.WriteLine(name + " has been excluded at {0} grade",count-1);
                    break;
                }
                if (count == 12)
                {
                    Console.WriteLine(name + " graduated. Average grade: {0:F2}",(gradesSum/12));
                    break;
                }
                count++;
            }
        }
    }
}
