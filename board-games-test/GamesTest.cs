﻿using NUnit.Framework;
using Moq;
using BoardGames.Model.CommonEntities;

[TestFixture]
internal class GamesTests
{
    [Test]
    public void GetPlayers_ReturnsPlayers()
    {
        // Arrange
        var mockGame = new Mock<Games>() { CallBase = true };
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
