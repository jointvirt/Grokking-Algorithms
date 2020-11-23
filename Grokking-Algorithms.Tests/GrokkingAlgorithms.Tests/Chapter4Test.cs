using System.Collections;
using System.Collections.Generic;
using Chapter_4;
using NUnit.Framework;

namespace GrokkingAlgorithms.Tests
{
    public class Chapter4Test
    {
        private readonly QuickSort _quickSort = new QuickSort();

        [TestCase(new int[] {5, 4, 3, 2, 1}, ExpectedResult = new int[] {1, 2, 3, 4, 5})]
        [TestCase(new int[] {-1, -2, 5, 8, 1, 13}, ExpectedResult = new int[] {-2, -1, 1, 5, 8, 13})]
        [TestCase(new int[] {4, 6, 8, 2, 3, 1, 5, 9, 7}, ExpectedResult = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9})]
        public IEnumerable<int> QuickSort_Sorting_ReturnsExceptedArray(IEnumerable<int> array)
        {
            return _quickSort.QuickSorting(array);
        }
    }
}