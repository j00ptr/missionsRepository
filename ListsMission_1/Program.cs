using System;
using System.Collections.Generic;

namespace ListsMission_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = ["<name>", "Ana", "Felipe"];
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
