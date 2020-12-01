using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = "";
            double score = 0;
            double totalScore = 0;
            double currentTotal = 0;
            double presentationCounter = 0;
            while (true)
            {
                presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    break;
                }
                presentationCounter++;
                for (int i = 0; i < jury; i++)
                {
                    score = double.Parse(Console.ReadLine());
                    currentTotal += score;
                }
                Console.WriteLine("{0} - {1:F2}.", presentation, currentTotal/jury);
                totalScore += currentTotal/jury;
                currentTotal = 0;
            }
            Console.WriteLine("Student's final assessment is {0:F2}.", totalScore/presentationCounter);
        }
    }
}
