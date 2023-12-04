using System;

namespace _13
{
    internal class Program
    {
        static void Main()
        {
            int p = 0;
            Console.WriteLine("Introduceti numarul de numere din secventa plus numerele din secventa(separarea se va face prin ENTER)");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    p++;
                    if (p > 1) break;
                }
                a = b;
            }
            if (p < 2) Console.WriteLine("secventa de numere este o secventa crescatoare rotita");
            else Console.WriteLine("secventa de numere nu este o secventa crescatoare rotita");

        }
    }
}
