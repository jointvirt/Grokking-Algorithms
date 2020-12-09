using Binary_Search;
using Chapter_2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Chapter_3;
using Chapter_4;
using Chapter_5;
using Chapter_6;
using Chapter_7;

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
            var smallList = new List<int>() { 4, 3, 8, 1, 9, 5, 2, 6, 7 };
            var smallArr = new int[] { 4, 3, 8, 1, 9, 5, 2, 6, 7 };
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

            #region Сортировка выбором.

            stopwatch.Start();
            SelectionSort selectionSort = new SelectionSort();
            Console.WriteLine(string.Join(", ", selectionSort.SelectionSorting(smallList)));
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения сортировки выбором: {stopwatch.Elapsed}"); //Совет: запустите несколько раз и примерно найдите среднее.
            stopwatch.Reset();

            #endregion

            #region Рекурсия.

            stopwatch.Start();
            Rekursion rekursion = new Rekursion();
            Console.WriteLine(rekursion.Factorial(5));
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения рекурсии: {stopwatch.Elapsed}"); //Совет: запустите несколько раз и примерно найдите среднее.

            #endregion

            #region Быстрая сортировка.

            stopwatch.Start();
            QuickSort quickSort = new QuickSort();
            Console.WriteLine(string.Join(", ", quickSort.QuickSorting(smallArr)));
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения быстрой сортировки: {stopwatch.Elapsed}"); //Совет: запустите несколько раз и примерно найдите среднее.

            #endregion

            #region Хеш-таблицы

            stopwatch.Start();
            HashTables hashTables = new HashTables();
            Console.WriteLine(hashTables.Check("Egor"));
            Console.WriteLine(hashTables.Check("Egor"));
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения заполнения хеш таблицы: {stopwatch.Elapsed}");
            
            #endregion

            #region Поиск в ширину

            stopwatch.Start();
            BreadthFirstSearch breadthFirstSearch = new BreadthFirstSearch();
            
            breadthFirstSearch._graph.Add("you", new[] { "alice", "bob", "claire" });
            breadthFirstSearch._graph.Add("bob", new[] { "anuj", "peggy" });
            breadthFirstSearch._graph.Add("alice", new[] { "peggy" });
            breadthFirstSearch._graph.Add("claire", new[] { "thom", "jonny" });
            breadthFirstSearch._graph.Add("anuj", Array.Empty<string>());
            breadthFirstSearch._graph.Add("peggy", Array.Empty<string>());
            breadthFirstSearch._graph.Add("thom", Array.Empty<string>());
            breadthFirstSearch._graph.Add("jonny", Array.Empty<string>());
            Console.WriteLine(breadthFirstSearch.Search("you"));
            
            stopwatch.Stop();
            
            Console.WriteLine($"Время выполнения: {stopwatch.Elapsed}");

            #endregion

            #region Алгоритм Дейкстры

            stopwatch.Start();

            FindLowest findLowest = new FindLowest();
            Console.WriteLine(findLowest.Find());
            stopwatch.Stop();

            Console.WriteLine($"Время выполнения: {stopwatch.Elapsed}");
            #endregion
        }
    }
}
