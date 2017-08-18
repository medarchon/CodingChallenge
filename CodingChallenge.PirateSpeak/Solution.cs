using System;
using System.Linq;
using System.Collections.ObjectModel

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            // throw new NotImplementedException();
        }
    }
}


// split letters into indexes of array
// put all in lowercase
// will need to get array length
// foreach
// search dictionary for all letters starting with first
// then followed with all for second, all for third, etc
// if match, run with next indexes

// or

// array of all scrambled combinations
// then match indexes to dictionary
// add matches to new array




function setUp (jumble, dictionary){
    let letters = jumble.ToLower().split('');  //set up array of letters from user entry
    let n = letters.length; // determine length of array for future loops

    function Unscramble (letters, n){
        let stop = false;
        let mixletters = [];     // temp storage for each scramble, to be cleared each time
        let firstmix = [];   // firstRun results
        let finalmixes = [];  //  all final possible scrambles
        while (n!=0){
            function firstRun (letters, n){
                for (let i = 0; i < n; i++)
                {
                    mixletters.push(i);    // create scramble
                }
                let mixword = mixletters.join(',');  //join letters together into one scramble
                firstmix.push(mixword);  // add scramble to results array
                let mixletters = [];   // clear temp storage
            };
            let n = n-1;   //reduce counter
            let popped = letters.pop();  //remove last index
            let reworked = letters.splice(1,0,popped);    //add last index to second spot
            firstRun(reworked, n);
        }
    }
}