using System;

namespace _4
{
    internal class Program
    {
        static void Main()
        {
            int p = -1, i = 0;
            Console.WriteLine("Introduceti numarul dorit si numerele din secventa(separarea se va face prin space)");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            int b = int.Parse(tokens[0]);
            foreach (string token in tokens)
            {
                if (i == 0) { i++; continue; }
                int a = int.Parse(token);
                if (a == b) p++;
            }
            if (p == -1) Console.WriteLine(p);
            else Console.WriteLine(++p);
        }
    }
}
