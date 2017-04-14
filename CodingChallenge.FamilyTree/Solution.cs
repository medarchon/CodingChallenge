using System;

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
            //call recursive helper method to walk the tree
            var descendant = GetDescendantSeeker(person, descendantName);

            return descendant?.Birthday.ToString("MMMM") ?? string.Empty;
        }
        
        //recursive method to search the tree for decendantName
        private Person GetDescendantSeeker(Person person, string descendantName)
        {
            Console.WriteLine(person.Name);

            if (person.Name == descendantName)
            {
                return person;
            }

            foreach (var d in person.Descendants)
            {
                var result = GetDescendantSeeker(d, descendantName);

                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }
    }
}

