using System;
using System.Collections.Generic;

namespace Methods_Mission1
{
    internal class Program
    {
        static void MyMethod(string fname)
        {
            Console.Write("Fighters" + fname + ", ");
        }

        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }
    }
}
