using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDesign1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ordinalNumbers = new List<string>();
            for (int i = 1; i < 31; i++)
            {
                ordinalNumbers.Add(OrdinalNumber(i));
                Console.WriteLine(ordinalNumbers[i - 1]);
            }
        }

        /*Identifying last digit of int:

        int % 10

        Identifying second to last digit of int:

        (int / 10) % 10
        */

        static string OrdinalNumber(int number)
        {
            string ordinalNumber;
            int lastDigit = number % 10;
            int secondToLastDigit = (number / 10) % 10;

            if (secondToLastDigit == 1)
            {
                ordinalNumber = number + "th";
                return ordinalNumber;
            }
            else
            {
                switch (lastDigit)
                {
                    case 1:
                        ordinalNumber = number + "st";
                        return ordinalNumber;
                    case 2:
                        ordinalNumber = number + "nd";
                        return ordinalNumber;
                    case 3:
                        ordinalNumber = number + "rd";
                        return ordinalNumber;
                    default:
                        ordinalNumber = number + "th";
                        return ordinalNumber;

                }
            }
        }
    }
}
