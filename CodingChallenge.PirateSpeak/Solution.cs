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












function firstUnscramble(jumble) {
  let letters = jumble.toLowerCase().split(""); // set up array of letters from user entry
  let mixletters = []; // temp storage for each scramble, to be cleared each time
  let firstMix = []; // firstRun results
  let revMix = [];  // reverse results
  let finalMix = []; //  all final possible scrambles
  let k = 2;  // set t0 double permutations
  for (let i = 1; i < letters.length + 1; i++) {  // setting up permutations counter
    k = k * i;
  }
  let n = letters.length; // save length of array

  var firstRun = function(word) {
    let letters = word.split("");  //turn jumble into letters
    let l = letters.length;
    if (k !== 0) {
      // rotate order of letters and push to array
      for (let i = 0; i < letters.length; i++) {
        mixletters.push(letters[i]);
        revMix.unshift(letters[i]);
      } // create scramble

      let mixWord = mixletters.join(""); //join letters together into one scramble
      let revWord = revMix.join("");
      // firstMix.push(mixWord); // add scramble to results array
      // for (var j = 0; j < firstMix.length; j++) {
      //   if (mixWord != firstMix[j]) {
      //     firstMix.push(mixWord); //add scramble to final results
      //   } else {
      //     break;
      //   }
      // }
      firstMix.push(mixWord);
      firstMix.push(revWord);
      k = k - 2;  //reduce permutation counter
      mixletters = [];   // clear temp storages
      revMix = [];
      l = l - 1;   //reduce counter
      let popped2 = letters.pop(); //remove last index
      let reworked2 = letters.splice(0, 0, popped2); //add last index to first spot
      mixWord = letters.join("");
      // firstRun(mixWord);
    } else {
        console.log("done");
    }
  };

  for (let i = 0; i <= letters.length; i++) {  //STARTING POINT
    if (n !== 0) {
      let spliced = letters.splice(i, 1);  // take out one index
      let popped = spliced.pop();           //remove string from that array
      let reworked = letters.splice(0, 0, popped);  //add removed to front of array
      let mixWord = letters.join("");  //join into one string
      firstMix.push(mixWord);   //push to subsolution array
      n = n - 1;                    //  reduce counter
      let respliced = letters.splice(0, 1);  //rework array back to original state
      let popped2 = respliced.pop();
      let fixed = letters.splice(i, 0, popped2);

    } else {                //once done, begin pushing subsolution indexes through firstRun shuffle
      for (let i = 0; i < firstMix.length; i++) {
        firstRun(firstMix[i]);
      }
    }
  }
}

firstUnscramble("1234");



