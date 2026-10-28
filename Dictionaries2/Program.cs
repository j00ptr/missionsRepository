using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> countryCapitals = new SortedList<string, string>();
            countryCapitals.Add("Sweden", "Stockholm"); //adding a key/value using the Add() method
            countryCapitals.Add("Burkina Faso", "Ouagadougou");
            countryCapitals.Add("Chile", "Santiago ");
            countryCapitals.Add("China", "Beijing");
            countryCapitals.Add("Mexico", "Mexico City");

            var random = new Random();
            int randomIndex = random.Next(countryCapitals.Count);
            Console.WriteLine("What is the capital of " + countryCapitals.ElementAt(randomIndex).Key + "?");

            string answer = Console.ReadLine();

            if (answer == countryCapitals.ElementAt(randomIndex).Value)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. It is " + countryCapitals.ElementAt(randomIndex).Value + ".");
            }
        }
    }
}
