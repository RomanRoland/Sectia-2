using System;
using System.ComponentModel.Design.Serialization;

namespace _1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un sir de numere");
            int p = 0, i = 0;
            string x = Console.ReadLine();
            string[] tokens = x.Split(' ');
            foreach (string a in tokens)
            {
                i = int.Parse(a);
                if (i % 2 == 0) p++;
            }
            Console.WriteLine("In sir sunt " + p + " numere pare");
        }
    }
}
