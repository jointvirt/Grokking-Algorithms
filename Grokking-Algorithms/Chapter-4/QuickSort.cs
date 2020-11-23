using System.Collections.Generic;
using System.Linq;

namespace Chapter_4
{
    public class QuickSort
    {
        public IEnumerable<int> QuickSorting(IEnumerable<int> list)
        {
            if (list.Count() < 2)
            {
                return list;
            }

            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return QuickSorting(less).Union(new List<int> { pivot }).Union(QuickSorting(greater));
        }
    }
}