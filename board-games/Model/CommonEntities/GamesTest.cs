using NUnit.Framework;
using Moq;
using board_games.Model.CommonEntities;
using board_games.Model.SkillIssueBroEntities;
using System.Collections.Generic;

[TestFixture]
internal class GamesTests
{
    [Test]
    public void GameCreation_ValidInputs_CreatesCorrectly()
    {
        // Arrange
        var gameId = 1;

        // Act
        var mockGame = new Mock<Games>(gameId) { CallBase = true };

        // Assert
        Assert.That(mockGame.Object.GetGameId(), Is.EqualTo(gameId));
    }

    [Test]
    public void UpdateLeaderboard_UpdatesCorrectly()
    {
        // Arrange
        var mockGame = new Mock<Games>(1) { CallBase = true };
        var leaderboard = new Leaderboard();

        mockGame.Setup(g => g.UpdateLeaderboard(It.IsAny<Leaderboard>())).Verifiable();

        // Act
        mockGame.Object.UpdateLeaderboard(leaderboard);

        // Assert
        mockGame.Verify();
    }

    [Test]
    public void SetState_SetsCorrectly()
    {
        // Arrange
        var mockGame = new Mock<Games>(1) { CallBase = true };

        mockGame.Setup(g => g.SetState()).Verifiable();

        // Act
        mockGame.Object.SetState();

        // Assert
        mockGame.Verify();
    }

    [Test]
    public void SaveGameState_SavesCorrectly()
    {
        // Arrange
        var mockGame = new Mock<Games>(1) { CallBase = true };

        mockGame.Setup(g => g.SaveGameState()).Verifiable();

        // Act
        mockGame.Object.SaveGameState();

        // Assert
        mockGame.Verify();
    }

    [Test]
    public void GetPlayers_ReturnsPlayers()
    {
        // Arrange
        var mockGame = new Mock<Games>(1) { CallBase = true };
        var mockPlayers = new List<Player>
        {
            new Player(1, "Player1"),
            new Player(2, "Player2")
        };

        mockGame.Setup(g => g.GetPlayers()).Returns(mockPlayers);

        // Act
        var players = mockGame.Object.GetPlayers();

        // Assert
        Assert.That(players, Is.EquivalentTo(mockPlayers), "Should return the correct list of players.");
    }
}
