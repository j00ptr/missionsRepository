using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Classes_Boss_Level_Part_1
{
    class Program
    {
        class Location
        {
            public string Name;
            public string Description;
            public List<Location> Neighbors = new List<Location>();
        }
        static void Main(string[] args)
        {
            List<Location> locations = new List<Location>{
                new Location {Name = "Winterfell", Description = "the capital of the Kingdom of the North"},
                new Location {Name = "Pyke", Description = "the stronghold and seat of House Greyjoy"},
                new Location {Name = "Riverrun", Description = "a large castle located in the central-western part of the Riverlands"},
                new Location {Name = "The Trident", Description = "one of the largest and most well-known rivers on the continent of Westeros"},
                new Location {Name = "King's Landing", Description = "the capital, and largest city, of the Seven Kingdoms"},
                new Location {Name = "Highgarden", Description = "the seat of House Tyrell and the regional capital of the Reach"}
            };

            Location currentLocation = locations[2];
            Console.WriteLine("Welcome to " + currentLocation.Name + ", " + currentLocation.Description + ".");
        }
    }
}
