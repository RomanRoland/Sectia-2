using System;

namespace _14
{
    internal class Program
    {
        static void Main()
        {
            int p = 0,p1 = 0, b = 0, i = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            int a = int.Parse(tokens[0]);
            foreach (string token in tokens)
            {
                if (i == 0) { i++; continue; }
                b = int.Parse(token);
                if (a > b) p++;
                if (b > a) p1++;
                a = b;
            }
            if (p < 2 || p1 < 2) Console.WriteLine("secventa de numere este o secventa monotona rotita");
            else Console.WriteLine("secventa de numere nu este o secventa monotona rotita");
        }
    }
}
