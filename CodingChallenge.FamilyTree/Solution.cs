using System;
using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
            bool contains = person.Descendants.Any(d => d.Name == descendantName);
            //if any of the decendants of the person have this name, then return true  

            if (contains)
            {
                Person myPerson = person.Descendants.Find(d => d.Name == descendantName);

                string birthMonth = myPerson.Birthday.ToString("MMMM");

                return birthMonth;
            }

            else
            {
                throw new NotImplementedException();
            }
        }
    }
}