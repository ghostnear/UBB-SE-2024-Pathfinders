namespace BoardGames.src.Sort
{
    public interface SortStrategy<T> where T : IComparable<T>
    {
        void Sort(List<T> data);
    }
}
