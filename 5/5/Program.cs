using System;
using System.Security.Cryptography;

namespace _5
{
    internal class Program
    {
        static void Main()
        {
            int p = 0, i = 0;
            Console.WriteLine("Introduceti numarul de numere din secventa plus numerele din secventa(separarea se va face prin Space)");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                int b = int.Parse(Console.ReadLine());
                if (i == b) p++;
                i++;
            }
            Console.WriteLine(p);
        }
    }
}
