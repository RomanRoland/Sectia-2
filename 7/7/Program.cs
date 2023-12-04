using System;

namespace _7
{
    internal class Program
    {
        static void Main()
        {
            int min = 2147483647, max = -2147483647;
            Console.WriteLine("Introduceti o secventa de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                int b = int.Parse(token);
                if (b < min) min = b;
                if (b > max) max = b;
            }
            Console.WriteLine($"minimul este {min} si maximul este {max}");
        }
    }
}
