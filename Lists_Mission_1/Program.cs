using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;

var random = new Random();
List<int> availableAbilityScores = new List<int>();
for (int a = 0; a < 6; a++)
{
    
    Console.Write($"You roll");
    List<int> diceResults = new List<int>();
    for (int i = 0; i < 4; i++)
    {
        int dieThrow;
        dieThrow = random.Next(1, 7);
        Console.Write($" {dieThrow}");
        diceResults.Add(dieThrow);
        if (i == 3)
        {
        
            Console.Write(".");
                    
            Console.Write($" The ability score is ");
            diceResults.Sort();
            diceResults.RemoveAt(0);
            var total = diceResults.Sum();
            Console.Write($"{total}.");
            Console.WriteLine();
            availableAbilityScores.Add(total);
        }
        else
        {
            Console.Write(",");
        }
    }
}

Console.Write("Your available ability scores are");
var x = 6;
availableAbilityScores.Sort();
foreach (var i in availableAbilityScores)
{
    Console.Write($" {i}");
    x--;
    if (x == 0)
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(",");
    }
}
Console.WriteLine();