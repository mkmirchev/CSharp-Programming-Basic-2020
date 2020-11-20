using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openedTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double taxFB = 150.00;
            double taxIG = 100.00;
            double taxRT = 50.00;
            string link;
            while (salary >=0 && openedTabs >= 0)
            {
                link = Console.ReadLine();
                if (link == "Facebook")
                {
                    salary -= taxFB;
                }
                if (link == "Instagram")
                {
                    salary -= taxIG;
                }
                if (link == "Reddit")
                {
                    salary -= taxRT;
                }
                openedTabs--;
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
            
        }
    }
}
