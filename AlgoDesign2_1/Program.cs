using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDesign2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = new List<string>();

            participants.Add("Chrys");
            participants.Add("Caj");
            participants.Add("Carl");
            participants.Add("Cindy");
            
            Console.WriteLine("Signed-up participants: " + string.Join(", ", participants));
            var userInput = Console.ReadKey();
            Console.WriteLine();
            if (userInput.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Generating starting order...");
                Console.WriteLine();
                Console.Write("Starting order: " + ShuffleList(participants));
            }
        }
        static string ShuffleList(List<string> items)
        {
            var random = new Random();

            for (int i = items.Count; i > 0; i--)
            {
                int ran = random.Next(0, i); 
                string randomString = items[ran];

                if (items.ElementAt(ran) != items.ElementAt(i-1))
                {
                    items.Insert(i, randomString);
                    items.Insert(ran, items.ElementAt(i-1));
                    items.Remove(items.ElementAt(ran + 1));
                    items.Remove(items.ElementAt(i-1));
                }      
            }
            string startingOrder = string.Join(", ", items);
            return startingOrder;
        }
    }
}
