using System;
using System.Security.Cryptography;

namespace _1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti un sir de numere: ");
            int p = 0, pp = 0, pn = 0 ;
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                int a = int.Parse(token);
                if (a > 0) pp++;
                else if (a < 0) pn++;
                else p++;
            }
            Console.WriteLine($"In secventa sunt: {pp} numere pozitive, {pn} numere negative, {p} numere egale cu 0");
        }
    }
}

