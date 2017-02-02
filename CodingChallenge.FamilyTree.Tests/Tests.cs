using Given.Common;
using Xunit;

namespace CodingChallenge.FamilyTree.Tests
{
    
    public class TreeTests
    {
        
        [Fact]
        public void if_the_person_exists_in_tree_the_result_should_be_january()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Joe");
            result.ShouldEqual("January");
        }
           
        [Fact]
        public void if__the_person_exists_at_the_top_tree_the_result_should_be_may()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Ted");
            result.ShouldEqual("May");
        }

        [Fact]
        public void if_the_person_does_not_exist_in_the_tree_the_result_should_be_empty()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Jeebus");
            result.ShouldEqual("");
        }
    }
}
