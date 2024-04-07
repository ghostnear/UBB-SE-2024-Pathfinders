using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using board_games.Model.GameOfLife.Cards;
using board_games.Model.GameOfLife.Mocks;

namespace board_games.Model.GameOfLife
{
    public class GameOfLifeBoard //: Games
    {
        private static readonly int _gameId = 1;
        private List<Tile> _tiles;
        private int _currentPlayerId;
        private readonly Spinner _spinner;
        private Leaderboard _leaderboard;
        private List<Card> _cards;
        private List<Player> _players;
        private List<Pawn> _pawns;
        private IFileLogger _logger;

        public GameOfLifeBoard()
        {
            _tiles = new List<Tile>(); // TODO populate tiles?
            // TODO currPlayerId
            _spinner = new Spinner();
            _leaderboard = new Leaderboard(); // ?
            // TODO _cards, _players, _pawns
            _logger = new SimpleFileLogger();
        }
    }
}
