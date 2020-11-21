using System;

namespace StepCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps;
            int totalSteps = 0;
            while (true)
            {
                steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    totalSteps += int.Parse(steps);
                    if (totalSteps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine("{0} steps over the goal!", totalSteps - 10000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} more steps to reach goal.", 10000 -totalSteps);
                        break;
                    }
                }
                totalSteps += int.Parse(steps);
                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine("{0} steps over the goal!",totalSteps-10000);
                    break;
                }
            }
        }
    }
}
