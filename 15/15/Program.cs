using System;

namespace _15
{
    internal class Program
    {
        static void Main()
        {
            int p = 0, i = 0;
            bool t = true;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            if (a > b) t = false;
            a = b;
            foreach (string token in tokens)
            {
                if (i < 2) { i++; continue; }
                b = int.Parse(token);
                switch (p)
                {
                    case 0: if (a > b) p++; break; 
                    case 1: if (a < b) p++; break;
                }
                if (p > 2) break;
                a = b;
            }
            if (p == 1 && t) Console.WriteLine("Secventa de numere este una bitonica");
            else Console.WriteLine("Secventa de numere nu este una bitonica");
        }
    }
}
