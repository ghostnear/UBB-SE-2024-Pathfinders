using NUnit.Framework;
using board_games.Model.CommonEntities;

[TestFixture]
internal class TileTests
{
    [Test]
    public void TileCreation_ValidInputs_CreatesCorrectly()
    {
        // Arrange
        var tileId = 1;
        var centerX = 1.5f;
        var centerY = 2.5f;

        // Act
        var tile = new Tile(tileId, centerX, centerY);

        // Assert
        Assert.That(tile.GetTileId(), Is.EqualTo(tileId), "Tile ID should match.");
        Assert.That(tile.GetCenterXPosition(), Is.EqualTo(centerX), "Tile's center X position should match.");
        Assert.That(tile.GetCenterYPosition(), Is.EqualTo(centerY), "Tile's center Y position should match.");
    }

    [Test]
    public void GetTileId_ReturnsCorrectId()
    {
        // Arrange
        var tileId = 2;
        var centerX = 1.0f;
        var centerY = 1.0f;
        var tile = new Tile(tileId, centerX, centerY);

        // Act
        var retrievedId = tile.GetTileId();

        // Assert
        Assert.That(retrievedId, Is.EqualTo(tileId), "Tile ID should match.");
    }

    [Test]
    public void GetCenterXPosition_ReturnsCorrectX()
    {
        // Arrange
        var tileId = 3;
        var centerX = 1.0f;
        var centerY = 2.0f;
        var tile = new Tile(tileId, centerX, centerY);

        // Act
        var retrievedX = tile.GetCenterXPosition();

        // Assert
        Assert.That(retrievedX, Is.EqualTo(centerX), "Center X position should match.");
    }

    [Test]
    public void GetCenterYPosition_ReturnsCorrectY()
    {
        // Arrange
        var tileId = 4;
        var centerX = 2.0f;
        var centerY = 1.0f;
        var tile = new Tile(tileId, centerY, centerY);

        // Act
        var retrievedY = tile.GetCenterYPosition();

        // Assert
        Assert.That(retrievedY, Is.EqualTo(centerY), "Center Y position should match.");
    }
}
