using board_games.Model.CommonEntities;

namespace board_games.Model.SkillIssueBroEntities
{
    internal class SkillIssueBoard : Games
    {
        private int _currentPlayerId;
        private List<Player> _players;
        private List<Pawn> _pawns;
        private List<SiBTile> _sibTiles;
        private Dice _sixSidedDice;

        public SkillIssueBoard(List<SiBTile> tiles,List<Pawn> pawns, List<Player> players, int idOfFirstPlayerToRoll)
        {
            _sibTiles = tiles;
            _players = players;
            _currentPlayerId = idOfFirstPlayerToRoll;
            _sixSidedDice = new Dice();
            _pawns = pawns;
        }

        public override List<Player> GetPlayers()
        {
            return _players;
        }

        public List<SiBTile> GetTiles()
        {
            return _sibTiles;
        }

        public List<Pawn> GetPawns()
        {
            return _pawns;
        }

        public Dice GetDice()
        {
            return _sixSidedDice;
        }

        public void UpdatePawns(List<Pawn> newPawns)
        {
            _pawns = newPawns;
            //SaveGameState();
        }
    }
}
