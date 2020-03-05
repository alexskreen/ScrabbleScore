using System;
using ScrabbleWord.Models;

namespace Scrabble.Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word and the application will tell you how many points it scores in Scrabble: ");
            string userInput = Console.ReadLine();
            Game testGame = new Game(userInput);

            Console.WriteLine("The word " + userInput + " scored " +             testGame.GameCount() + " points.");
        }
    }
}