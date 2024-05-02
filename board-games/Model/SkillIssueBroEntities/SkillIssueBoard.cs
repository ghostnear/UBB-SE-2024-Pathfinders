using BoardGames.Model.CommonEntities;

namespace BoardGames.Model.SkillIssueBroEntities
{
    internal class SkillIssueBoard : Games
    {
        private List<Player> players;
        private List<Pawn> pawns;
        private List<SiBTile> sibTiles;
        private Dice sixSidedDice;

        public SkillIssueBoard(List<SiBTile> tiles,List<Pawn> pawns, List<Player> players, int idOfFirstPlayerToRoll)
        {
            sibTiles = tiles;
            this.players = players;
            sixSidedDice = new Dice();
            this.pawns = pawns;
        }

        public override List<Player> GetPlayers()
        {
            return players;
        }

        public List<SiBTile> GetTiles()
        {
            return sibTiles;
        }

        public List<Pawn> GetPawns()
        {
            return pawns;
        }

        public Dice GetDice()
        {
            return sixSidedDice;
        }

        public void UpdatePawns(List<Pawn> newPawns)
        {
            pawns = newPawns;
            // SaveGameState();
        }
    }
}
