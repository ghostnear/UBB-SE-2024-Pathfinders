namespace BoardGames.Model.CommonEntities
{
    public class Player
    {
        private int id;
        private string name;
        public List<Pawn> Pawns { get; set; } = new List<Pawn>();

        public Player(int playerId, string playerName)
        {
            id = playerId;
            name = playerName;
        }

        public string GetPlayerName()
        {
            return name;
        }
        public int GetPlayerId()
        {
            return id;
        }
    }
}
