using Binary_Search;
using NUnit.Framework;

namespace GrokkingAlgorithms.Tests
{
    public class Chapter1Test
    {
        private readonly BinarySearch bn = new BinarySearch();

        [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 15, ExpectedResult = 15)]
        [TestCase(new int[] { 1 }, 1, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 7, ExpectedResult = 7)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8, ExpectedResult = 0)]
        [TestCase(new int[] { -2, -1, 0, 1, 2, 3, 4, 5, 6, 7 }, -1, ExpectedResult = 0)]
        public int BinarySearch_Binary_ReturnsExceptedNumber(int[] array, int number)
        {
            return bn.Binary(array, number);
        }
    }
}