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
            var orderedJumble = String.Concat(jumble.OrderBy(c => c));

            return (from word in dictionary let orderedWord = String.Concat(word.OrderBy(c => c)) where orderedWord == orderedJumble select word).ToArray(); //convert list to array
        }

    }
}