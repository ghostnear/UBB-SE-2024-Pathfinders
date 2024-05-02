﻿namespace board_games.src.Sort
{
    public class GnomeSortStrategy<T> : ISortStrategy<T>
        where T : IComparable<T>
    {
        private int sortingMultiplier = 1;
        public GnomeSortStrategy() { }
        public GnomeSortStrategy(bool isAscending)
        {
            if (!isAscending)
            {
                sortingMultiplier = -1;
            }
        }
        public void Sort(List<T> data)
        {
            for (int index = 1; index < data.Count;)
            {
                if (data[index - 1].CompareTo(data[index]) * sortingMultiplier <= 0)
                {
                    ++index;
                }
                else
                {
                    T temporary = data[index];
                    data[index] = data[index - 1];
                    data[index - 1] = temporary;
                    --index;
                    if (index == 0)
                    {
                        index = 1;
                    }
                }
            }
        }
    }
}