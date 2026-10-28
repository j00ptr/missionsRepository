using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Mission_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yearString;
            Console.WriteLine("What year is it?");
            yearString = Console.ReadLine();
            int yearInput = Int32.Parse(yearString);

            int seasonInput = 0;
            string seasonString;
            Console.WriteLine("What time of the year is it? What season?");
            seasonString = Console.ReadLine();
            switch (seasonString)
            {
                case "spring":
                    seasonInput = 0;
                    break;
                case "summer":
                    seasonInput = 1;
                    break;
                case "autumn":
                    seasonInput = 2;
                    break;
                case "winter":
                    seasonInput = 3;
                    break;
            }

            string dayString;
            string endInput;
            Console.WriteLine($"Really? Hm. What day of {seasonString} is it?");
            dayString = Console.ReadLine();
            bool endsWithOne = dayString.EndsWith("1");
            bool endsWithTwo = dayString.EndsWith("2");
            bool endsWithThree = dayString.EndsWith("3");

            if (endsWithOne == true)
            {
                endInput = "st";
            }
            else if (endsWithTwo == true)
            {
                endInput = "nd";
            }
            else if (endsWithThree == true)
            {
                endInput = "rd";
            }
            else
            {
                endInput = "th";
            }

            int dayInput = Int32.Parse(dayString);

            Console.WriteLine(CreateDayDescription(dayInput, seasonInput, yearInput, endInput));
            

        }
        static string CreateDayDescription(int day, int seasonInt, int year, string dayEnd)
        {
            string[] season = { "spring", "summer", "autumn", "winter" };
            string dayDescription = "Ah, okay. So it is the " + day + $"{dayEnd} day of {season[seasonInt]} in the year " + year + ".";
            return dayDescription;
        }
    }
}
