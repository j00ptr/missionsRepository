using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace ClassesBossLevel2
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
            var random = new Random();
            Location currentLocation = locations[random.Next(0, 6)];

            ConnectLocations(locations[0], locations[1]);
            ConnectLocations(locations[0], locations[3]);
            ConnectLocations(locations[1], locations[2]);
            ConnectLocations(locations[1], locations[5]);
            ConnectLocations(locations[2], locations[3]);
            ConnectLocations(locations[2], locations[4]);
            ConnectLocations(locations[2], locations[5]);
            ConnectLocations(locations[3], locations[4]);
            ConnectLocations(locations[4], locations[5]);
            //I assume 9 are the minimum required

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome to " + currentLocation.Name + ", " + currentLocation.Description + ".");
                Console.WriteLine();
                Console.WriteLine("Possible destinations are:");
                foreach (var Neighbor in currentLocation.Neighbors)
                {
                    Console.WriteLine((currentLocation.Neighbors.IndexOf(Neighbor) + 1) + "." + Neighbor.Name);
                }
                Console.WriteLine();
                Console.WriteLine("Where do you want to travel?");
                currentLocation = currentLocation.Neighbors[Convert.ToInt32(Console.ReadLine()) - 1];
                Console.WriteLine();
            }

        }
        static void ConnectLocations(Location firstLocation, Location secondLocation)
        {
            firstLocation.Neighbors.Add(secondLocation);
            secondLocation.Neighbors.Add(firstLocation);
        }
    }
}