using System;
using System.Collections.Generic;

namespace CodingChallenge.FamilyTree
{
    public class Person
    {
        public Person()
        {
            Descendants = new List<Person>();
        }

        public string Name { get; set; }
        public List<Person> Descendants { get; set; }
        public DateTime Birthday { get; set; }
    }

    public static class FamilyTreeGenerator
    {
        public static Person Make()
        {
            return new Person
            {
                Name = "Ted",
                Birthday = DateTime.Parse("5/5/1950"),
                Descendants = new List<Person>
                {
                    new Person
                    {
                        Name = "Sally",
                        Birthday = DateTime.Parse("4/5/1965"),
                        Descendants = new List<Person>
                        {
                            new Person {Name = "Bob", Birthday = DateTime.Parse("9/5/1995")}
                        }
                    },
                    new Person
                    {
                        Name = "Jim",
                        Birthday = DateTime.Parse("3/5/1966"),
                        Descendants = new List<Person>
                        {
                            new Person {Name = "Joe", Birthday = DateTime.Parse("1/5/1985")},
                            new Person {Name = "George", Birthday = DateTime.Parse("6/5/1995")}
                        }
                    }
                }
            };
        }
    }
}