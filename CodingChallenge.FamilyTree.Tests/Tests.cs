using Given.Common;
using Given.NUnit;

namespace CodingChallenge.FamilyTree.Tests
{
    public class person_exists_in_tree : Scenario
    {
        static Person _tree;
        static string _result;

        given a_family_tree = () => _tree = FamilyTreeGenerator.Make();

        when searching_the_tree_for_joes_birthday = () => _result = new Solution().GetBirthMonth(_tree, "Joe");

        [then]
        public void the_result_should_be_january()
        {
            _result.ShouldEqual("January");
        }
    }

    public class person_exists_at_the_top_tree : Scenario
    {
        static Person _tree;
        static string _result;

        given a_family_tree = () => _tree = FamilyTreeGenerator.Make();

        when searching_the_tree_for_joes_birthday = () => _result = new Solution().GetBirthMonth(_tree, "Ted");

        [then]
        public void the_result_should_be_may()
        {
            _result.ShouldEqual("May");
        }
    }

    public class person_does_not_exist_in_the_tree : Scenario
    {
        static Person _tree;
        static string _result;

        given a_family_tree = () => _tree = FamilyTreeGenerator.Make();

        when searching_the_tree_for_joes_birthday = () => _result = new Solution().GetBirthMonth(_tree, "Jeebus");

        [then]
        public void the_result_should_be_may()
        {
            _result.ShouldEqual("");
        }
    }
}
