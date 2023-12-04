using System;

namespace _6
{
    internal class Program
    {
        static void Main()
        {
            bool p = true;
            int b = 0, i = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            int a = int.Parse(tokens[0]);
            foreach (string token in tokens)
            {
                if (i  == 0) { i++; continue; }
                b = int.Parse(token);
                if (a > b) p = false;
                a = b;
            }
            if (p) Console.WriteLine("numerele sunt in ordine crescatoare");
            else Console.WriteLine("numerele nu sunt in ordine crescatoare");
        }
    }
}
