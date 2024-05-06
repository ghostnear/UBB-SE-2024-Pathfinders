using NUnit.Framework;
using BoardGames.Model.GameOfLife;
using System.Collections.Generic;
using Moq;
using BoardGames.Model.CommonEntities;
using NUnit.Framework.Legacy;
using BoardGames.View.SkillIssueBro.Pawns;

namespace BoardGames.Tests.GameOfLife
{
    [TestFixture]
    public class GameOfLifeBoardTest
    {
        [Test]
        public void Constructor_WhenCalled_ShouldInitializeSpinnerAndPlayersList()
        {
            var gameOfLifeBoard = new GameOfLifeBoard();

            Assert.That(gameOfLifeBoard, Is.Not.Null, "Board should not be null");
            Assert.That(gameOfLifeBoard.GetPlayers(), Is.Not.Null, "Players should not be null");
        }

        [Test]
        public void SpinSpinner_WhenCalled_ShouldReturnValidNumber()
        {
            var gameOfLifeBoard = new GameOfLifeBoard();

            for(int i = 0; i < 100; i++)
            {
                int result = gameOfLifeBoard.SpinSpinner();

                Assert.That(result, Is.InRange(1, 10));
            }
        }

        [Test]
        public void GetPlayers_WhenCalled_ShouldReturnPlayersList()
        {
            var gameOfLifeBoard = new GameOfLifeBoard();
            var playersList = new List<Player> ();

            var result = gameOfLifeBoard.GetPlayers();
            CollectionAssert.AreEqual(playersList, result);
        }
    }
}
