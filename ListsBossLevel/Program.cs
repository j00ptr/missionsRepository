//List and variable establishments
List<string> partyMembers = ["roger", "chrysalis", "bigbone", "innajeez"];
var random = new Random();
var basiliskHealth = 16;

//Scenario
Console.Write($"Fighters {partyMembers[0]}, {partyMembers[1]}, {partyMembers[2]}, {partyMembers[3]} descend into the dungeon.");
Console.WriteLine();
for (int i = 0; i < 8; i++)
{
    var dEight = random.Next(1, 9);
    basiliskHealth += dEight;
}
Console.WriteLine($"A basilisk with {basiliskHealth} HP appears!");

//Fight
do
{
    Console.WriteLine();
    foreach (var partyMember in partyMembers)
    {
        var dFour = random.Next(1, 5);
        basiliskHealth -= dFour;
        if (basiliskHealth < 0)
        {
            basiliskHealth = 0;
        }
        Console.WriteLine($"{partyMember} hits the basilisk for {dFour} damage. Basilisk has {basiliskHealth} HP left.");
    }
    if (basiliskHealth > 0)
    {
        Console.WriteLine();
        int gazeTarget = random.Next(0, partyMembers.Count);
        var savingThrow = 0;
        var dTwenty = random.Next(1, 21);
        savingThrow = 3 + dTwenty;
        Console.WriteLine($"The basilisk uses petrifying gaze on {partyMembers[gazeTarget]}");
        if (savingThrow > 11)
        {
            Console.WriteLine($"{partyMembers[gazeTarget]} rolls a {savingThrow} and is saved from the attack.");
        }
        else
        {
            Console.WriteLine($"{partyMembers[gazeTarget]} rolls a {savingThrow} and fails to be saved. {partyMembers[gazeTarget]} is turned into stone.");
            partyMembers.Remove(partyMembers[gazeTarget]);
        }
    }
}
while (basiliskHealth > 0 && partyMembers.Count > 0);
Console.WriteLine();
if (basiliskHealth == 0)
{
    Console.WriteLine("The basilisk collapses and the heroes celebrate their victory!");
}
else
{
    Console.WriteLine("The party has failed and the basilisk continues to turn unsuspecting adventurers to stone.\r\n");
}