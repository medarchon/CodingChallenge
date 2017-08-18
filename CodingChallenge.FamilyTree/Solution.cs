using System;
using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {    
            var descendant = findDescendant(person, descendantName); // search tree for descendant

            return descendant?.Birthday.ToString("MMMM") ?? string.Empty; // return descendant
        }

        private Person findDescendant(Person person, string descendantName) // search descendantName
        {
            return person.Name == descendantName ? person : person.Descendants.Select(i => findDescendant(i, descendantName)).FirstOrDefault(result => result != null); // return descendant or null if not found
        }
    }
}




