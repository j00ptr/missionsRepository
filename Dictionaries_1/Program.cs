using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> winterOlympicCountries = new Dictionary<int, string>();
            winterOlympicCountries[2002] = "United States";
            winterOlympicCountries[2006] = "Italy";
            winterOlympicCountries[2010] = "Canada";
            winterOlympicCountries[2014] = "Russia";
            winterOlympicCountries[2018] = "South Korea";
            winterOlympicCountries[2022] = "China";
            winterOlympicCountries[2026] = "Italy";

            var random = new Random();

            int randomIndex = random.Next(winterOlympicCountries.Count);
            string randomIndexString = winterOlympicCountries.ElementAt(randomIndex).Value;
            int year = 1998 + (randomIndex + 1) * 4;
            Console.WriteLine("Which country hosted the Winter Olympic Games in " + year + "?");
            string answer = Console.ReadLine();
            Console.WriteLine();
            if (answer == randomIndexString)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. It was " + randomIndexString + ".");
            }
        }
    }
}
