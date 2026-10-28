using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDesign2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int randomNumber = random.Next(0,11);

            Console.WriteLine(randomNumber + "! = " + Factorial(randomNumber));
        }
        static int Factorial(int n)
        {
            {
                if (n <= 1)
                {
                    return 1;
                }
                return n * Factorial(n - 1);
            }
        }
    }
}
