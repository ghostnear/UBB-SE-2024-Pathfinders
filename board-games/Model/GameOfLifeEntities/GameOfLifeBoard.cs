using board_games.Model.CommonEntities;

namespace board_games.Model.GameOfLife
{
    internal class GameOfLifeBoard : Games
    {
        private readonly Spinner spinner;
        private List<Player> players;

        public GameOfLifeBoard()
        {
            spinner = new Spinner();
            players = new List<Player>();
        }

        public override List<Player> GetPlayers()
        {
            return players;
        }

        public int SpinSpinner()
        {
            return spinner.RollSpinner();
        }
    }
}
