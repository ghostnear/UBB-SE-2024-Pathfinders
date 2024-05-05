using NUnit.Framework;
using BoardGames.Model.CommonEntities;

[TestFixture]
internal class PlayerTests
{
    [Test]
    public void PlayerCreation_WithValidInputs_CreatesCorrectly()
    {
        // Arrange
        var playerId = 1;
        var playerName = "Player One";

        // Act
        var player = new Player(playerId, playerName);

        // Assert
        Assert.That(player.GetPlayerId(), Is.EqualTo(playerId), "Should create player with correct ID.");
        Assert.That(player.GetPlayerName(), Is.EqualTo(playerName), "Should create player with correct name.");
    }

    [Test]
    public void GetPlayerId_WhenCalled_ReturnsCorrectId()
    {
        // Arrange
        var playerId = 2;
        var playerName = "Player Two";
        var player = new Player(playerId, playerName);

        // Act
        var retrievedId = player.GetPlayerId();

        // Assert
        Assert.That(retrievedId, Is.EqualTo(playerId), "Should return correct player ID.");
    }

    [Test]
    public void GetPlayerName_WhenCalled_ReturnsCorrectName()
    {
        // Arrange
        var playerId = 3;
        var playerName = "Player Three";
        var player = new Player(playerId, playerName);

        // Act
        var retrievedName = player.GetPlayerName();

        // Assert
        Assert.That(retrievedName, Is.EqualTo(playerName), "Should return correct player name.");
    }
}
