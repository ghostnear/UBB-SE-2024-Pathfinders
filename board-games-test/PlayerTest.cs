using NUnit.Framework;
using BoardGames.Model.CommonEntities;

[TestFixture]
internal class PlayerTests
{
    [Test]
    public void PlayerCreation_ValidInputs_CreatesCorrectly()
    {
        // Arrange
        var playerId = 1;
        var playerName = "Player One";

        // Act
        var player = new Player(playerId, playerName);

        // Assert
        Assert.That(player.GetPlayerId(), Is.EqualTo(playerId), "Player ID should match.");
        Assert.That(player.GetPlayerName(), Is.EqualTo(playerName), "Player name should match.");
    }

    [Test]
    public void GetPlayerId_ReturnsCorrectId()
    {
        // Arrange
        var playerId = 2;
        var playerName = "Player Two";
        var player = new Player(playerId, playerName);

        // Act
        var retrievedId = player.GetPlayerId();

        // Assert
        Assert.That(retrievedId, Is.EqualTo(playerId), "Retrieved ID should match the expected ID.");
    }

    [Test]
    public void GetPlayerName_ReturnsCorrectName()
    {
        // Arrange
        var playerId = 3;
        var playerName = "Player Three";
        var player = new Player(playerId, playerName);

        // Act
        var retrievedName = player.GetPlayerName();

        // Assert
        Assert.That(retrievedName, Is.EqualTo(playerName), "Retrieved name should match the expected name.");
    }
}
