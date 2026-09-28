using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missionMageAndWarrior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "Jona";
            Console.WriteLine($"Welcome to Dungeon World, {playerName}! We call upon you to oversee a team of adventurers in a series of battle that will decide the fate of the world itself!");

            string warriorName = "Felix Guattari";
            string mageName = "Gilles Deleuze";
            string narrative = "The party stared down the stone stairs into darkness. \"We should've brough some torches with us,\" remarked WARRIOR. MAGE turned around and replied, \"Worry not dear WARRIOR, let me shine some light for you,\" as she cast a Continual light spell.";
            narrative = narrative.Replace("WARRIOR", $"{warriorName}");
            narrative = narrative.Replace("MAGE", $"{mageName}");
            Console.WriteLine(narrative);
        }
    }
}
