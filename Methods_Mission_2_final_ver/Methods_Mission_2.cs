using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace wtf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> characterNames = new List<string>();
            characterNames.Add("roger");
            characterNames.Add("chrysalis");
            characterNames.Add("bigbone");
            characterNames.Add("innajeez");

            Console.WriteLine($"Fighters {string.Join(", ", characterNames)} descend into the dungeon.");
            Console.WriteLine();

            var random = new random();
            int orcHP = DiceRoll(2, random.Next(1, 9), 6);
            Console.WriteLine($"Watch out, Orc with" + orcHP + "HP appears!");
            SimulateCombat(characterNames, "Orc", 10);
            SimulateCombat(characterNames, "Azer", 18);
            SimulateCombat(characterNames, "Troll", 16);

            if (characterNames.Count > 0)
            {
                Console.WriteLine($"After three grueling battles, the heroes {string.Join(", ", characterNames)} return from the dungeons to live another day.");
            }
            else
            {
                Console.WriteLine("The party has failed and the troll continues to attack unsuspecting adventurers.");
            }
        }
        static void SimulateCombat(List<string> characterNames, string monsterName, int savingThrowDC)
        {
            var random = new Random();
            Console.WriteLine();
            while (monsterHP > 0 && characterNames.Count > 0)
            {
                foreach (var character in characterNames)
                {
                    if (monsterHP > 0)
                    {
                        var greatsword = 2 * random.Next(1, 7);
                        monsterHP -= greatsword;

                        if (monsterHP < 0)
                        {
                            monsterHP = 0;
                        }

                        if (characterNames.Count > 0)
                        {
                            Console.WriteLine($"{character} hits the {monsterName} for {greatsword} damage. The {monsterName} has {monsterHP} HP left.");
                        }
                    }
                }
                if (monsterHP > 0)
                {
                    int attackTarget = random.Next(0, characterNames.Count);
                    Console.WriteLine();
                    Console.WriteLine($"The {monsterName} attacks {characterNames[attackTarget]}!");
                    int savingThrow = 3 + random.Next(1, 21);
                    if (savingThrow >= savingThrowDC)
                    {
                        Console.WriteLine($"{characterNames[attackTarget]} rolls a {savingThrow} and is saved from the attack.");
                    }
                    else
                    {
                        Console.WriteLine($"{characterNames[attackTarget]} rolls a {savingThrow} and fails to be saved. {characterNames[attackTarget]} is killed.");
                        characterNames.Remove($"{characterNames[attackTarget]}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"The {monsterName} collapses and the heroes celebrate their victory!");
                    Console.WriteLine();
                }
            }
        }
        static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0)
        {
            return numberOfRolls * diceSides + fixedBonus;
        }

    }
}