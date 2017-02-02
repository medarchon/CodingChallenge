using Given.Common;
using Xunit;

namespace CodingChallenge.PirateSpeak.Tests
{
    public class PirateSpeakTests
    {

        [Theory] 
        [InlineData("trisf", new []{"first"}, new[] {"first"})]
        [InlineData("oob", new[] {"bob", "baobob"},new string[0])]
        [InlineData("ainstuomn", new[] { "mountains", "hills", "mesa" }, new[] { "mountains" })]
        [InlineData("oopl", new[] { "donkey", "pool", "horse", "loop" }, new[] { "pool", "loop" })]
        [InlineData("oprst", new[] {"sport", "ports", "ball", "bat", "port"}, new[] {"sport", "ports"})]
        public void TestPirateVocabulary(string jumble, string[] dictionary, object expectedResult)
        {
            var actualResult = new Solution().GetPossibleWords(jumble, dictionary);
            actualResult.ShouldBeTheSameAs(expectedResult);
        }
    }
}

