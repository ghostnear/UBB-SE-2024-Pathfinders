namespace BoardGames.src.Sort
{
    public interface ISortStrategy<T>
        where T : IComparable<T>
    {
        void Sort(List<T> data);
    }
}
