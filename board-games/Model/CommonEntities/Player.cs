namespace BoardGames.Model.CommonEntities
{
    internal class Player
    {
        private int id;
        private string name;

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
