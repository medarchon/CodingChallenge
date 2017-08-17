using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            List<string> PossibleWords = new List<string>();

            String UnJumbledWord = String.Concat(jumble.OrderBy(i => i)); // arrange jumble words in alpha. order

            foreach (var word in dictionary) 
            {
                string dictionaryWord = String.Concat(word.OrderBy(i => i)); // arrange dic. word in alpha. order

                if (dictionaryWord == UnJumbledWord) // if the two are = 
                {
                    PossibleWords.Add(word); // add word to the list
                }          
            }
            return PossibleWords.ToArray(); // return list to array
        }
    } 
}

         