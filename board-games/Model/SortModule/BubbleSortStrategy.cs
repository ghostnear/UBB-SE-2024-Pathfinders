﻿namespace board_games.src.Sort
{
    public class BubbleSortStrategy<T> : ISortStrategy<T>
        where T : IComparable<T>
    {
        private int sortingMultiplier = 1;

        public BubbleSortStrategy() { }
        public BubbleSortStrategy(bool isAscending)
        {
            if (!isAscending)
            {
                sortingMultiplier = -1;
            }
        }
        public void Sort(List<T> data)
        {
            bool sorted = false;
            int length = data.Count;

            while (!sorted)
            {
                sorted = true;
                for (int index = 0; index < length - 1; index++)
                {
                    if (data[index].CompareTo(data[index + 1]) * sortingMultiplier > 0)
                    {
                        sorted = false;
                        T temporary = data[index];
                        data[index] = data[index + 1];
                        data[index + 1] = temporary;
                    }
                }
                length--;
            }
        }
    }
}
