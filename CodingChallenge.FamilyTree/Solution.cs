using System;
using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {    
            var descendant = findDescendant(person, descendantName);

            return descendant?.Birthday.ToString("MMMM") ?? string.Empty;
        }

        private Person findDescendant(Person person, string descendantName)
        {
            return person.Name == descendantName ? person : person.Descendants.Select(i => findDescendant(i, descendantName)).FirstOrDefault(result => result != null);
        }
    }
}




