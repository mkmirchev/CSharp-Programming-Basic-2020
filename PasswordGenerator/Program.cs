using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            bool handBreak = false;
            for (int i = 1; i < n; i++)
            {
                for (int k = 1; k < n; k++)
                {
                    int bigger = 0;
                    if (i > k)
                    {
                        bigger = i+1;
                    }
                    else
                    {
                        bigger = k+1;
                    }
                    for (int j = 0; j < l; j++)
                    {
                        char firstChar = Convert.ToChar(97 + j);
                        for (int m = 0; m < l; m++)
                        {
                            char secondChar = Convert.ToChar(97 + m);
                            for (int h = bigger; h <= n; h++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",i, k, firstChar, secondChar, h);
                            }
                        }
                    }
                }
            }
        }
    }
}
