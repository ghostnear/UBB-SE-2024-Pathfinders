using NUnit.Framework;
using BoardGames.Model.SkillIssueBroEntities;
using BoardGames.Model.CommonEntities;
using System.Collections.Generic;

namespace BoardGames.Tests.SkillIssueBroEntities
{
    [TestFixture]
    public class GameBoardTest
    {
        [Test]
        public void Constructor_WhenCalled_ShouldInitializeMembers()
        {
            // Arrange
            var tiles = new List<GameTile>();
            var pawns = new List<Pawn>();
            var players = new List<Player>();

            // Act
            var gameBoard = new GameBoard(tiles, pawns, players);

            // Assert
            Assert.That(gameBoard,Is.Not.Null);
            Assert.That(tiles, Is.EqualTo(gameBoard.GetTiles()));
            Assert.That(pawns, Is.EqualTo(gameBoard.GetPawns()));
            Assert.That(players, Is.EqualTo(gameBoard.GetPlayers()));
            Assert.That(gameBoard.GetDice(),Is.Not.Null);
        }

        [Test]
        public void UpdatePawns_WhenCalled_ShouldUpdatePawns()
        {
            // Arrange
            var initialPawns = new List<Pawn> { new Pawn(1,new Tile(1,1,1)) };
            var updatedPawns = new List<Pawn> { new Pawn(1, new Tile(1, 1, 1)), new Pawn(2, new Tile(1, 1, 1)) };
            var gameBoard = new GameBoard(new List<GameTile>(), initialPawns, new List<Player>());

            // Act
            gameBoard.UpdatePawns(updatedPawns);

            // Assert
            Assert.That(updatedPawns,Is.EqualTo(gameBoard.GetPawns()));
        }
    }
}
