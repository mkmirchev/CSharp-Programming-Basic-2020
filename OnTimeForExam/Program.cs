using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hArrive = int.Parse(Console.ReadLine());
            int mArrive = int.Parse(Console.ReadLine());
            int examTimeInMinutes = hExam * 60 + mExam;
            int arriveTimeInMinutes = hArrive * 60 + mArrive;
            if (examTimeInMinutes<arriveTimeInMinutes)
            {
                //late
                Console.WriteLine("Late");
                if (arriveTimeInMinutes <= examTimeInMinutes+59)
                {
                    int minutesAfterTheStart = arriveTimeInMinutes - examTimeInMinutes;
                    Console.WriteLine("{0} minutes after the start", minutesAfterTheStart);
                }
                else
                {
                    int hoursAfterTheStart = (arriveTimeInMinutes - examTimeInMinutes) / 60;
                    int minutesAfterTheStart = (arriveTimeInMinutes - examTimeInMinutes) % 60;
                    Console.WriteLine("{0}:{1:D2} hours after the start", hoursAfterTheStart, minutesAfterTheStart);
                }
            }
            else if (examTimeInMinutes>=arriveTimeInMinutes && examTimeInMinutes-30 <= arriveTimeInMinutes)
            {
                //on time
                Console.WriteLine("On time");
                if (examTimeInMinutes-1 >= arriveTimeInMinutes) 
                {
                    int minutesBeforeTheStart = examTimeInMinutes - arriveTimeInMinutes;
                    Console.WriteLine("{0} minutes before the start",minutesBeforeTheStart);
                }
            }
            else if (examTimeInMinutes-30 > arriveTimeInMinutes)
            {
                //early
                Console.WriteLine("Early");
                if (examTimeInMinutes - 60 < arriveTimeInMinutes)
                {
                    int minutesBeforeTheStart = examTimeInMinutes - arriveTimeInMinutes;
                    Console.WriteLine("{0} minutes before the start", minutesBeforeTheStart);
                }
                else if (examTimeInMinutes - 60 >= arriveTimeInMinutes)
                {
                    int hoursBeforeTheStart = (examTimeInMinutes - arriveTimeInMinutes) / 60;
                    int minutesBeforeTheStart = (examTimeInMinutes - arriveTimeInMinutes) % 60;
                    Console.WriteLine("{0}:{1:D2} hours before the start", hoursBeforeTheStart, minutesBeforeTheStart);
                }
            }
        }
    }
}
