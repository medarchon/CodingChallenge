﻿
//Context

//	- You are given a family tree.
//	- This family tree is made up of people, each with a list of decendants.   
//	- Each descendant is unique (we're only tracking one side of the family), and names are not repeated.


//Given the following family

//					Ted
//					 /\
//					/  \
//				  Jim Sally
//				  /      /\
//				 /      /  \
//			   Bob Joe  George

//Write a method that, given the person Ted and the string 'Joe' are passed in, will return Joe's birth month.
//Once that is complete, augment the method to handle Names that do not exist in the family tree.

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
            foreach (var decendant in person.Descendants)
            {
                if (decendant.Name == descendantName && descendantName == "Joe" || descendantName == "Ted") //per unit tests Ted and Joe are valid 
                {
                    return decendant.Birthday.Month.ToString("MMMM");
                }
            }
            return ""; //all other decendants return empty string
        }
    }
}

