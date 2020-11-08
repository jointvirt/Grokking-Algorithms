using Binary_Search;
using System;
using System.Diagnostics;

namespace Grokking_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Визуализация бинарного поиска.
            Stopwatch sw = new Stopwatch();

            sw.Start();
            var bn = new BinarySearch();
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(bn.Binary(arr, 19));
            sw.Stop();

            Console.WriteLine($"Время выполнения данного кода: {sw.Elapsed}"); //Совет: запустите несколько раз и примерно найдите среднее.
            #endregion
        }
    }
}
