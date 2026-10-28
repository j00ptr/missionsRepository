using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AlgoDesign1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Change the contents of the list and get a different outcome in JoinWithAnd():
            List<string> heroes = new List<string>();
            heroes.AddRange(new string[] {"Chrys", "Caj"});

            //Change the truth value of the following bool depending on preference:
            bool serialCommaBeforeAndYorN = false;

            Console.WriteLine("The heroes in the party are: " + JoinWithAnd(heroes, serialCommaBeforeAndYorN) + ".");

        }

        static string JoinWithAnd(List<string> items, bool useSerialComma = true)
        {
            //Turn this first row of if/else statements into switch statements
            switch (items.Count)
            {
                case 0:
                    string EmptyString = "";
                    return EmptyString;
                case 1:
                    return items[0];
                case 2:
                    string twoStrings = string.Join(" and ", items);
                    return twoStrings;
                default:
                    string[] copy = new string[items.Count];
                    items.CopyTo(copy);

                    if (useSerialComma == true)
                    {
                        copy[copy.Length - 1] = "and " + copy.ElementAt(copy.Length - 1);
                        string write = string.Join(", ", copy);
                        return write;
                    }
                    else
                    {
                        string lastTwoStrings = copy.ElementAt(copy.Length - 2) + " and " + copy.ElementAt(copy.Length - 1);
                        copy[copy.Length - 2] = lastTwoStrings;
                        copy = copy.Take(copy.Count() - 1).ToArray();
                        string write = string.Join(", ", copy);
                        return write;


                    }
            }
        }
    }
}
