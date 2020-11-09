namespace Binary_Search
{
    public class BinarySearch
    {
        /// <summary>
        /// Бинарный поиск.
        /// </summary>
        /// <param name="array">Массив с числами.</param>
        /// <param name="num">Число которое нужно найти.</param>
        /// <returns>Возвращает это число, если оно присутствует в массиве, иначе вернёт 0</returns>
        public int Binary(int[] array, int num)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = array[mid];
                if (guess == num)
                {
                    return guess;
                }
                else if (guess > num)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return 0;
        }
    }
}
