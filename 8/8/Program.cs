using System;

namespace _8
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            long f1 = 0, f2 = 1;
            int i = 3;
            Console.Write($"Numarul {n} din numarul lui Fibonacci este: ");
            do
            {
                i++;
                f2 += f1;
                f1 = f2 - f1;  
            } while (i <= n);
            if (n != 1) Console.Write(f2);
            else Console.Write("0");
            Console.WriteLine();
        }
    }
}
