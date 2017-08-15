using Given.Common;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodingChallenge.FamilyTree.Tests
{
    
    public class TreeTests
    {
        
        [Fact]
        public void if_the_person_exists_in_tree_the_result_should_be_january()
        {
            var Ted = new Person
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


            var result = new Solution().GetBirthMonth(Ted, "Joe");
            Assert.Equal(result, "January");
        }
           
        [Fact]
        public void if__the_person_exists_at_the_top_tree_the_result_should_be_may()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Ted");
            Assert.Equal(result, "May");
        }

        [Fact]
        public void if_the_person_does_not_exist_in_the_tree_the_result_should_be_empty()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Jeebus");
            Assert.Equal(result, "");
        }
    }
}
