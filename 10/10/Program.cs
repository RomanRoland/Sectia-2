using System;

namespace _10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un sir de numere");
            int p = 0, max = int.MinValue, maxp = 0;
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                int a = int.Parse(token);
                if (a > max)
                {
                    max = a;
                    p = 1;
                    maxp = 0;
                    continue;
                }
                else
                    if (max == a)
                    p++;
                else
                {
                    if (p > maxp)
                        maxp = p;
                    p = 0;
                }
            }
            if (p > maxp)
                maxp = p;
            Console.WriteLine("Valoarea maxima este {0} si apare de {1} ore", max, maxp);
        }
    }
}
