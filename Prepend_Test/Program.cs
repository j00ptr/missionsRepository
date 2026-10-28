using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepend_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(", ", numbers[1].Prepend(0)));
        }
    }
}
