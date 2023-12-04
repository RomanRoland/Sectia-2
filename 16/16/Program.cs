using System;

namespace _16
{
    internal class Program
    {
        static void Main()
        {
            int p = 0 , t = 0, i = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            if (a > b) p ++;
            a = b;
            foreach (string token in tokens)
            {
                if (i < 2) { i++; continue; }
                b = int.Parse(token);
                switch (p)
                {
                    case 0: if (a > b) { p++; t++; } break;
                    case 1: if (a < b) { p--; t++; } break;
                }
                if (p > 2) break;
                a = b;
            }
            if (t < 3 && t > 0) Console.WriteLine("Secventa de numere este una bitonica rotita");
            else Console.WriteLine("Secventa de numere nu este una bitonica rotita");
        }
    }
}
