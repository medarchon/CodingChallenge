using NUnit.Framework;

namespace CodingChallenge.PirateSpeak.Tests
{
    [TestFixture]
    public class PirateSpeakTests
    {

        [TestCase("trisf", new []{"first"}, Result = new[] {"first"})]
        [TestCase("oob", new[] {"bob", "baobob"}, Result = new string[0])]
        [TestCase("ainstuomn", new[] { "mountains", "hills", "mesa" }, Result = new[] { "mountains" })]
        [TestCase("oopl", new[] { "donkey", "pool", "horse", "loop" }, Result = new[] { "pool", "loop" })]
        [TestCase("oprst", new[] {"sport", "ports", "ball", "bat", "port"}, Result = new[] {"sport", "ports"})]
        public string[] TestPirateVocabulary(string jumble, string[] dictionary)
        {
            return new Solution().GetPossibleWords(jumble, dictionary);
        }
    }
}
