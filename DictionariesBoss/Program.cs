using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace DictionariesBoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> rankings = new Dictionary<string, int>();
            string newWinner = "newWinner";

            while (newWinner != "")
            {

                Console.Write("Who won this round? ");
                newWinner = Console.ReadLine();
                bool oldWinner = rankings.ContainsKey(newWinner);

                if (oldWinner == true)
                {
                    rankings[newWinner] += 1;
                }
                else
                {
                    rankings.Add(newWinner, 1);
                }           

                if (rankings.ContainsKey(""))
                {
                    rankings.Remove("");
                    ClearLine();
                    Console.WriteLine("The Final Result:");
                }

                var sortedDict = from entry in rankings orderby entry.Value descending select entry;

                foreach (var ranking in sortedDict)
                {
                    Console.WriteLine(ranking.Key + " " + ranking.Value);
                }
                Console.WriteLine();
            }
        }
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
