using board_games.Model.CommonEntities;

namespace board_games.Model.GameOfLife
{
    internal class GameOfLifeBoard : Games
    {
        private readonly Spinner _spinner;
        private List<Player> _players;

        public GameOfLifeBoard()
        {
            _spinner = new Spinner();
            _players = new List<Player>();
        }

        public override List<Player> GetPlayers()
        {
            return _players;
        }

        public int SpinSpinner()
        {
            return _spinner.RollSpinner();
        }
    }
}
