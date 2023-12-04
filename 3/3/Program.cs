using System;

namespace _3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            long  p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
                Console.WriteLine(p);
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {(n*(n+1))/2}, respectiv produsul {p}");
        }
    }
}
