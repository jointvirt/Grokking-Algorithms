using Chapter_5;
using NUnit.Framework;

namespace GrokkingAlgorithms.Tests
{
    public class Chapter5Test
    {
        private readonly HashTables _hashTables = new HashTables();

        [TestCase("Egor", ExpectedResult = "let them vote!")]
        [TestCase("Egor", ExpectedResult = "kick them out!" )]
        [TestCase("Roma", ExpectedResult = "let them vote!")]
        [TestCase("Darya", ExpectedResult = "let them vote!")]
        [TestCase("Roma", ExpectedResult = "kick them out!" )]
        public string BinarySearch_Binary_ReturnsExceptedNumber(string name)
        {
            return _hashTables.Check(name);
        }
    }
}