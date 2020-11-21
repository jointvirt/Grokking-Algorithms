using Chapter_2;
using NUnit.Framework;
using System.Collections.Generic;

namespace GrokkingAlgorithms.Tests
{
    class Chapter2Test
    {
        private readonly SelectionSort selectionSort = new SelectionSort();
        private static readonly object[] _sourceLists =
        {
            new object[] {new List<int> {2, 3, 1}, new int[] { 1, 2, 3 } },   
            new object[] {new List<int> {5, 6, 1, 4, 3, 2, 7, 9, 8}, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } } 
        };

        [Test, TestCaseSource("_sourceLists")]
        public int[] SelectionSort_SelectionSorting_ReturnsExceptedArray(List<int> list)
        {
            return selectionSort.SelectionSorting(list);
        }
    }
}
