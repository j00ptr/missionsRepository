using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgoDesign1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            List<int> streams = new List<int>();
            string symbols = @"!@#$%^&*()_+-=[];',.\/~{}:|<>?";

            for (int i = 0; i < 10; i++)
            {
                streams.Add(random.Next(0, 80));
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            while (true)
            {
                for (int x = 0; x < 80; x++)
                {
                    if (streams.Contains(x))
                    {
                        Console.Write(symbols[random.Next(symbols.Length)]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Thread.Sleep(100);

                if (random.Next(3) == 0)
                {
                    streams.RemoveAt(random.Next(streams.Count));
                }
                if (random.Next(3) == 0)
                { 
                    streams.Add(random.Next(0, 80)); 
                }
            }
            /*
            {
            Console.Write(streams.Contains(x)               condition 
            ?                                                   ?
            symbols[random.Next(symbols.Length)]             trueCase
            :                                                   :
            ' ';                                             falseCase
            }
            */
        }
    }
}
