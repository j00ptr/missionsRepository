using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Mission_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] monsterAmount = new int[100];
            var random = new Random();
            for (int i = 0; i < monsterAmount.Length; i++) 
            {
                monsterAmount[i] = random.Next(1, 51);
            }         
            Array.Sort(monsterAmount);

            Console.Write("Number of monsters in levels:");
            foreach (int monster in monsterAmount)
            {
                Console.Write(" " + monster + ",");
            }
            Console.Write("\b");
        }
    }
}
