using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ScrabbleWord.Models
{
    public class Game
    {
      public string Word;

      public Dictionary<char, int> letters = new Dictionary<char, int>()
        {
          {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, 
          {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
          {'D', 2}, {'G', 2},
          {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
          {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
          {'K', 5},
          {'J', 8}, {'X', 8},
          {'Q',10}, {'Z',10},
        };

      public Game(string word)
      {
        Word = word;
      }

        public string RemoveSpecialCharacters(string Word)
        {
        string cleanWord = Regex.Replace(Word, "[^a-zA-Z_.]+", "", RegexOptions.Compiled);
        string cleanUpperWord = cleanWord.ToUpper();
        return cleanUpperWord;
        }

        public int GameCount()
        {
            string result = RemoveSpecialCharacters(Word);
            int sum = 0; 
            
            char[] newArr = result.ToCharArray();

            foreach(char character in newArr)
            {
              if(letters.ContainsKey(character))
              {
                // sum += newArr[Word];
                sum += letters[character];
                // Console.WriteLine(letters[character]);
              }
              else 
              {
                sum += 0;
              }
            }
            Console.WriteLine(sum);
            return sum;
        }
      }
    }
