using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Mission_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name();
            Name();
        }
        static void Name()
        {
            string playerNamePath = "player-name.txt";
            string playerNamePathRead;
            if (File.Exists(playerNamePath))
            {
                playerNamePath = File.ReadAllText("player-name.txt");
                Console.WriteLine($"Welcome back, {playerNamePath}, let's continue!");
            }
            else
            {
                Console.WriteLine("Welcome to your biggest adventure yet!");
                Console.WriteLine();
                Console.WriteLine("What is your name, traveler?");
                Console.Write(">");
                playerNamePath = Console.ReadLine();
                File.WriteAllText("player-name.txt", playerNamePath);
                playerNamePathRead = File.ReadAllText("player-name.txt");
                Console.WriteLine();
                Console.WriteLine("Nice to meet you, " + playerNamePathRead);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }
    }
}
