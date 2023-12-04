using System;

namespace _17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un sir de numere");
            int p = 0;
            bool b = true;
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string token in tokens)
            {
                int i = int.Parse(token);
                switch (i)
                {
                    case 0: p++; break;
                    case 1: p--; break;
                }
                if (p < 0)
                {
                    b = false; 
                    break;
                }
            }
            if (p == 0 && b)
                Console.WriteLine("Secventa introdusa este corecta");
            else
                Console.WriteLine("Secventa introdusa nu este corecta");
        }
    }
}
