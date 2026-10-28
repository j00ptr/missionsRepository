using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Mission_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name();
        }
        static void Name()
        {
            string backers = File.ReadAllText("backers.txt");
            string playerName = File.ReadAllText("player-name.txt");

            Console.WriteLine("Welcome back, " + playerName + ", let's continue!");
            Console.WriteLine();

            if (backers.Contains("Fred"))
            {
                Console.WriteLine("You successfully enter Dr. Fred's secret laboratory and are greeted with a warm welcome for backing the game's Kickstarter!");
            }
            else
            {
                Console.WriteLine("Unfortunately I cannot let you into Dr. Fred's secret laboratory.");
            }
        }
    }
}
