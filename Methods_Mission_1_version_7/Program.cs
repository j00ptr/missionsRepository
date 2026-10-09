using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Mission_1_version_7
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

            Console.WriteLine(String.Join(", ", characterNames));

            SimulateCombat();
            SimulateCombat();
            SimulateCombat();

        }
        static void SimulateCombat(List<string> characterNames)
        {
            foreach (string characterName in characterNames)
            {
                Console.WriteLine(characterName);
            }
        }
    }
}
