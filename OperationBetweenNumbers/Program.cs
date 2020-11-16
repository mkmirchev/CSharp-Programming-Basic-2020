using System;

namespace operationbetweennumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberone = int.Parse(Console.ReadLine());
            int numbertwo = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            int total = 0;
            switch (operand)
            {
                case '+':
                    total = numberone + numbertwo;
                    if (total % 2 ==0)
                    {
                        Console.WriteLine("{0} + {1} = {2} - even", numberone, numbertwo, total);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2} - odd", numberone, numbertwo, total);
                    }
                    break;

                case '-':
                    total = numberone - numbertwo;
                    if (total % 2 == 0)
                    {
                        Console.WriteLine("{0} - {1} = {2} - even", numberone, numbertwo, total);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} = {2} - odd", numberone, numbertwo, total);
                    }
                    break;
                case '*':
                    total = numberone * numbertwo;
                    if (total % 2 == 0)
                    {
                        Console.WriteLine("{0} * {1} = {2} - even", numberone, numbertwo, total);
                    }
                    else
                    {
                        Console.WriteLine("{0} * {1} = {2} - odd", numberone, numbertwo, total);
                    }
                    break;
                case '/':
                    if (numbertwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberone} by zero");
                    }
                    else
                    {
                        double result = numberone * 1.0 / numbertwo;
                        Console.WriteLine($"{numberone} / {numbertwo} = {result:F2}");
                    }
                    break;
                case '%':
                    if (numbertwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberone} by zero");
                    }
                    else
                    {
                        total = numberone % numbertwo;
                        Console.WriteLine($"{numberone} % {numbertwo} = {total}");
                    }     
                    break;
                default:
                    break;
            }
        }
    }
}
