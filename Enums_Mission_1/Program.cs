using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Mission_1
{
    internal class Program
    {
        enum Suit
        {
            Heart,
            Spade,
            Diamond,
            Club
        }
        static void Main(string[] args) 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DrawAce(Suit.Heart);
            DrawAce(Suit.Spade);
            DrawAce(Suit.Diamond);
            DrawAce(Suit.Club);
        }
        static void DrawAce(Suit suit)
        {
            Console.WriteLine("╭───────╮");
            Console.WriteLine("│A      │");
            switch (suit)
            {
                case Suit.Heart:
                    Console.WriteLine("│♥      │");
                    break;
                case Suit.Spade:
                    Console.WriteLine("│♠      │");
                    break;
                case Suit.Diamond:
                    Console.WriteLine("│♦      │");
                    break;
                case Suit.Club:
                    Console.WriteLine("│♣      │");
                    break;
            }
            switch (suit)
            {
                case Suit.Heart:
                    Console.WriteLine("│   ♥   │");
                    break;
                case Suit.Spade:
                    Console.WriteLine("│   ♠   │");
                    break;
                case Suit.Diamond:
                    Console.WriteLine("│   ♦   │");
                    break;
                case Suit.Club:
                    Console.WriteLine("│   ♣   │");
                    break;
            }
            switch (suit)
            {
                case Suit.Heart:
                    Console.WriteLine("│      ♥│");
                    break;
                case Suit.Spade:
                    Console.WriteLine("│      ♠│");
                    break;
                case Suit.Diamond:
                    Console.WriteLine("│      ♦│");
                    break;
                case Suit.Club:
                    Console.WriteLine("│      ♣│");
                    break;
            }
            Console.WriteLine("│      A│");
            Console.WriteLine("╰───────╯");
        }
    }
}
