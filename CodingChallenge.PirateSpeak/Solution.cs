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



    function compareWords(scrambled, dictionary){

    }

}


function firstUnscramble(jumble) {
  let letters = jumble.toLowerCase().split("");
  console.log("firstjumble", letters);
  let mixletters = []; // temp storage for each scramble, to be cleared each time
  let firstMix = []; // firstRun results
  let finalMix = []; //  all final possible scrambles
  let k = 1;
  for (let i = 1; i < letters.length + 1; i++){
    k = k * i;
    console.log("k", k);
  }
  console.log("k", k);
  let n = letters.length; // determine length of array
  console.log("n", n);

  var firstRun = function(word) {
    // console.log("okay", word);
    let letters = word.split("");
    let l = letters.length;
    console.log("word", letters);
    console.log("k", k);
    if (k !== 0) {
      // rotate order of letters and push to array
      for (let i = 0; i < letters.length; i++) {
        mixletters.push(letters[i]);
      } // create scramble

      let mixWord = mixletters.join(""); //join letters together into one scramble
      console.log("mixletters", mixletters);
      // firstMix.push(mixWord); // add scramble to results array
      console.log("first", firstMix);
      finalMix.push(mixWord); //add scramble to final results
      console.log("final", finalMix);
      k = k - 1;
      mixletters = []; // clear temp storage
      l = l - 1; //reduce counter
      console.log("l2", l);
      console.log("letters", letters);
      let popped2 = letters.pop(); //remove last index
      console.log("pop", popped2);
      let reworked2 = letters.splice(0, 0, popped2); //add last index to first spot
      mixWord = letters.join("");
      console.log("reworked", mixWord);
      firstRun(mixWord);
    } else {
      console.log("done");
      console.log("finalMix", finalMix);
      console.log("firstMix", firstMix);
    }
  };

  for (let i = 0; i <= letters.length; i++) {
    if (n !== 0) {
      let spliced = letters.splice(i, 1);
      console.log("spliced", spliced);
      let popped = spliced.pop();
      let reworked = letters.splice(0, 0, popped);
      console.log("rework", letters);
      // let redo = letters;
      // console.log("redo", redo)
      // firstRun(redo);
      let mixWord = letters.join("");
      firstMix.push(mixWord);
      n = n - 1;
      let respliced = letters.splice(0, 1);
      let popped2 = respliced.pop();
      let fixed = letters.splice(i, 0, popped2);

      console.log("n", n);
      console.log("firstMix", firstMix);
    } else {
      console.log("first wave done");
      const run1 = firstMix.length;
      console.log("run1", run1);
      for (let i = 0; i < run1; i++) {
        console.log("mixfirst", firstMix[i]);
        // firstRun(firstMix[i]);
      }
    }
  }
}

firstUnscramble("1234");
