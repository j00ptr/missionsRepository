using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Mission_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            setThePrice();
            setThePrice();
            setThePrice();
            setThePrice();
            setThePrice();
        }
        static void setThePrice()
        {
            string price;
            Console.Write("Set the price: ");
            price = Console.ReadLine();
            string[] inputs = price.Split(' ');
            double firstNumber = Convert.ToDouble(inputs[0]);
            if (inputs.Length == 3)
            {
               double secondNumber = Convert.ToDouble(inputs[2]);
               switch (inputs[1])
               {
                   case "/":
                       Console.WriteLine("The price was set to " + firstNumber / secondNumber + ".");
                       break;
                   case "+":
                    case "add":
                    case "plus":
                       Console.WriteLine("The price was set to " + (firstNumber + secondNumber) + ".");
                       break;
                   case "-":
                    case "minus":
                       Console.WriteLine("The price was set to " + (firstNumber - secondNumber) + ".");
                       break;
                   case "*":
                    case "times":
                       Console.WriteLine("The price was set to " + firstNumber * secondNumber + ".");
                       break;
               }
            }
            else if (inputs.Length == 4) 
            {
                double secondNumber = Convert.ToDouble(inputs[3]);
                switch (inputs[1])
                {
                    case "divided":
                        Console.WriteLine("The price was set to " + firstNumber / secondNumber + ".");
                        break;
                }
            } 
            else
            {
                Console.WriteLine("The price was set to " + firstNumber + ".");
            }

            Console.WriteLine("--");
        }
    }
}
