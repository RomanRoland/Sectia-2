using System;

namespace _11
{
    internal class Program
    {
        static void Main()
        {
            long s = 0;
            int b1 = 0, b = 0;
            Console.WriteLine("Introduceti o serie de numere");
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                b = int.Parse(token);
                while (b != 0)
                {
                    b1 = b1*10 + b%10;
                    b /= 10;
                }
                s += b1;
                b1 = 0;
            }
            Console.WriteLine(s);
        }
    }
}
