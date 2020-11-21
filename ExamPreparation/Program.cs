using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            string taskName = "";
            int grade = 6;
            int poorGradesCount = 0;
            int tasksCount = 0;
            double totalScore = 0;
            string lastTask = "";
            while (true)
            {
                taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    Console.WriteLine("Average score: {0:F2}", totalScore/tasksCount);
                    Console.WriteLine("Number of problems: {0}", tasksCount);
                    Console.WriteLine("Last problem: " +lastTask);
                    break;
                }              
                grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    poorGradesCount++;
                }
                if (poorGrades == poorGradesCount)
                {
                    Console.WriteLine("You need a break, {0} poor grades.", poorGrades);
                    break;
                }
                tasksCount++;
                totalScore += grade;
                lastTask = taskName;
            }
        }
    }
}
