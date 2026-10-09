using System;
using System.Collections.Generic;

namespace Methods_Mission_1_ver4
{
    internal class Program
    {
        static void MyMethod(List<string> fname)
        {
            Console.WriteLine("Fighters" + fname);
        }

        static void Main(List<string>[] args)
        {
            List<string> fname = ["roger", "chrysalis", "bigbone", "innajeez"];
            MyMethod(fname);
        }

        // Liam is 5
        // Jenny is 8
        // Anja is 31
    }
}
