using Binary_Search;
using System;
using System.Diagnostics;

namespace Grokking_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Условные константы

            Stopwatch stopwatch = new Stopwatch();
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
                         26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                         51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75,
                         76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100};

            #endregion


            #region Тупой поиск

            stopwatch.Start();
            DumbSearch dumbSearch = new DumbSearch();
            Console.WriteLine(dumbSearch.Dumb(arr, 99));
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения \"тупого\" поиска: {stopwatch.Elapsed}"); //Совет: запустите несколько раз и примерно найдите среднее.
            stopwatch.Reset();

            #endregion


            #region Визуализация бинарного поиска.

            stopwatch.Start();
            BinarySearch binarySearch = new BinarySearch();
            Console.WriteLine(binarySearch.Binary(arr, 99));
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения бинарного поиска: {stopwatch.Elapsed}"); //Совет: запустите несколько раз и примерно найдите среднее.
            stopwatch.Reset();

            #endregion

            #region

            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения сортировки выбором: {stopwatch.Elapsed}"); //Совет: запустите несколько раз и примерно найдите среднее.
            stopwatch.Reset();

            #endregion
        }
    }
}
