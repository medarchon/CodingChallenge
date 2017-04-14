using System;
using System.Collections.Generic;
using System.Linq;


//Pirates have notorious difficulty with enunciating.They tend to blur all the letters together and scream at people.

//At long last, we need a way to unscramble what these pirates are saying.

//Write a function that will accept a jumble of letters as well as a dictionary, and output a list of words that the pirate might have meant.

//For example:

//GetPossibleWords ("ortsp", ["sport", "parrot", "ports", "matey"])
//Should return ["sport", "ports"].


namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            var matches = new List<string>();
            var orderedJumble = String.Concat(jumble.OrderBy(c => c));
         
            foreach (var word in dictionary) 
            {
                var orderedWord = String.Concat(word.OrderBy(c => c));

                if (orderedWord == orderedJumble) //sort jumbled and sort dictionary word then compare
                {
                    matches.Add(word);
                }
            }

            return matches.ToArray(); //convert list to array
        }

    }
}