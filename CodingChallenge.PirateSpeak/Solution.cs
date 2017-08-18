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
};


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

    function firstScramble (letters, n){
        let n = letters.length; // determine length of array
        let mixletters = [];     // temp storage for each scramble, to be cleared each time
        let firstmix = [];   // firstRun results
        let finalmixes = [];  //  all final possible scrambles
        while (n!=0){
            function firstRun (letters, n){
                for (let i = 0; i < letters.length; i++)
                {
                    mixletters.push(i);    // create scramble
                }
                let mixword = mixletters.join(',');  //join letters together into one scramble
                firstmix.push(mixword);  // add scramble to results array
                finalmixes.push(mixword); //add scramble to final results
                let mixletters = [];   // clear temp storage
                let n = n-1;   //reduce counter
                let popped = letters.pop();  //remove last index
                let reworked = letters.splice(0,0,popped);    //add last index to first spot
                firstRun(reworked, n);
            };
        };
        secondUnscramble(firstmix);
    }

    function secondScramble (words){   // function to take firstmix and create more scrambled options
        foreach (var word in words)
        {
            let splitWord = word.split('');
            let spliced = splitWord.splice(1,1);  //swap around first two indexes
            let reworked = splitWord.splice(0,0,spliced);
            let n = splitWord.length;
            while (n!=0){                   // run reworked word through same firstScramble process
                function firstRun (letters, n){
                    for (let i = 0; i < letters.length; i++)
                    {
                        mixletters.push(i);    // create scramble
                    }
                    let mixword = mixletters.join(',');  //join letters together into one scramble
                    firstmix.push(mixword);  // add scramble to results array
                    finalmixes.push(mixword); //add scramble to final results
                    let mixletters = [];   // clear temp storage
                    let n = n-1;   //reduce counter
                    let popped = letters.pop();  //remove last index
                    let reworked = letters.splice(0,0,popped);    //add last index to first spot
                    firstRun(reworked, n);
                };
            };
        };
        compareWords(finalmixes);
    }

    function compareWords(scrambled, dictionary){

    }

}