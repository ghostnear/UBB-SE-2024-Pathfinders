using board_games.Model.CommonEntities;

namespace board_games.Model.GameOfLife
{
    internal class GameOfLifePlayer : Player
    {
        public int Happiness;
        public int Money;

        public GameOfLifePlayer(int playerId, string playerName, int happiness, int money) : base(playerId, playerName)
        {
            this.Happiness = happiness;
            this.Money = money;
        }
    }
}
