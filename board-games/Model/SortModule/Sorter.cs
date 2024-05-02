namespace board_games.src.Sort
{
    public class Sorter<T>
        where T : IComparable<T>
    {
        private ISortStrategy<T>? strategy = null;
        public Sorter() { }
        public void SetStrategy(ISortStrategy<T> strategy)
        {
            this.strategy = strategy;
        }
        public void Sort(List<T> data) {
            if (strategy != null)
            {
                strategy.Sort(data);
            }
            else
            {
                throw new Exception("Strategy not selected");
            }
        }
    }
}
