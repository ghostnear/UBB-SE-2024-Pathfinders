using BoardGames.Model.CommonEntities;

namespace BoardGames.Model.GameOfLife
{
    internal class GameOfLifePlayer : Player
    {
        public int happiness;
        public int money;

        public GameOfLifePlayer(int playerId, string playerName, int happiness, int money) : base(playerId, playerName)
        {
            this.happiness = happiness;
            this.money = money;
        }
    }
}
