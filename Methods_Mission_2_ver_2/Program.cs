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
        static Random random = new Random();
        static void Main(string[] args)
        {
            List<string> characterNames = new List<string>();
            characterNames.Add("roger");
            characterNames.Add("chrysalis");
            characterNames.Add("bigbone");
            characterNames.Add("innajeez");

            Console.WriteLine($"Fighters {string.Join(", ", characterNames)} descend into the dungeon.");
            Console.WriteLine();

            int orcHP = DiceRoll(2, 8, 6);
            int azerHP = DiceRoll(6, 8, 12);
            int trollHP = DiceRoll(8, 8, 40);
            Console.WriteLine($"Watch out, an orc with " + orcHP + "HP appears!");
            SimulateCombat(characterNames, "Orc", orcHP, 10);
            Console.WriteLine($"Watch out, an azer with " + azerHP + "HP appears!");
            SimulateCombat(characterNames, "Azer", azerHP, 18);
            Console.WriteLine($"Watch out, a troll with " + trollHP + "HP appears!");
            SimulateCombat(characterNames, "Troll", trollHP, 16);

            if (characterNames.Count > 0)
            {
                Console.WriteLine($"After three grueling battles, the heroes {string.Join(", ", characterNames)} return from the dungeons to live another day.");
            }
            else
            {
                Console.WriteLine("GAME OVER");
            }
        }
        static void SimulateCombat(List<string> characterNames, string monsterName, int monsterHP, int savingThrowDC)
        {
            Console.WriteLine();
            while (monsterHP > 0 && characterNames.Count > 0)
            {
                foreach (var character in characterNames)
                {
                    if (monsterHP > 0)
                    {
                        var greatsword = DiceRoll(2, 8);
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
                    int savingThrow = DiceRoll(1, 20);
                    if(savingThrow >= savingThrowDC)
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
                if (monsterHP > 0 && characterNames.Count == 0)
                {
                    Console.WriteLine($"The party has failed and the {monsterName} continues to attack unsuspecting adventurers.");
                }
            }
        }
        static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0) //2, 8, 6 for orc
        {

            var diceResult = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                diceResult += random.Next(1, diceSides+1);
            }
            diceResult += fixedBonus;
            return diceResult;
        }

    }
}