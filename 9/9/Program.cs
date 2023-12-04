using System;

namespace _9
{
    internal class Program
    {
        static void Main()
        {
            bool d = true, c = true;
            int b = 0, i = 0;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            int a = int.Parse(tokens[0]);
            foreach (string token in tokens)
            {
                if (i == 0) { i++; continue; }
                b = int.Parse(token);
                if (b < a) d = false;
                else c = false;
            }
            if (d || c) Console.WriteLine("Secventa de numere este monotona");
            else Console.WriteLine("Secventa de numere nu este monotona");
        }
    }
}
