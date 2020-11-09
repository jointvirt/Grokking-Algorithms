namespace Binary_Search
{
    public class DumbSearch
    {
        /// <summary>
        /// Простой поиск или же "тупой" поиск
        /// </summary>
        /// <param name="array">Массив с числами.</param>
        /// <param name="num">Число которое нужно найти.</param>
        /// <returns>Возвращает это число, если оно присутствует в массиве, иначе вернёт 0</returns>
        public int Dumb (int[] array, int num)
        {
            foreach (var item in array)
            {
                if (item == num)
                {
                    return item;
                }
            }

            return 0;
        }
    }
}
