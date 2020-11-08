using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading points from console
            double points = double.Parse(Console.ReadLine());
            double bonusPts = 0;
            double pointsAfterFirstBonus = 0;
            double additionalBonusPts = 0;
            double pointsAfterSecondBonus = 0;
            //calculating bonus points
            if (points <= 100)
            {
                bonusPts = 5;
            }
            else if (points > 100 & points <= 1000)
            {
                bonusPts = points * 0.2;
            }
            else
            {
                bonusPts = points * 0.1;
            }
            pointsAfterFirstBonus = points + bonusPts;

            if (points % 2 == 0)
            {
                pointsAfterSecondBonus = pointsAfterFirstBonus + 1;
                bonusPts = bonusPts + 1;
            }
            else if (points % 5 == 0)
            {
                pointsAfterSecondBonus = pointsAfterFirstBonus + 2;
                bonusPts = bonusPts + 2;
            }
            else
            {
                pointsAfterSecondBonus = pointsAfterFirstBonus;
            }
            Console.WriteLine(bonusPts);
            Console.WriteLine(pointsAfterSecondBonus);

        }
    }
}
