using NUnit.Framework;
using BoardGames.Model.CommonEntities;

[TestFixture]
internal class TileTests
{
    [Test]
    public void TileCreation_WithValidInputs_CreatesCorrectly()
    {
        // Arrange
        var tileId = 1;
        var centerX = 1.5f;
        var centerY = 2.5f;

        // Act
        var tile = new Tile(tileId, centerX, centerY);

        // Assert
        Assert.That(tile.GetTileId(), Is.EqualTo(tileId), "Should create tile with correct ID.");
        Assert.That(tile.GetCenterXPosition(), Is.EqualTo(centerX), "Should create tile with correct center X position.");
        Assert.That(tile.GetCenterYPosition(), Is.EqualTo(centerY), "Should create tile with correct center Y position.");
    }

    [Test]
    public void GetTileId_WhenCalled_ReturnsCorrectId()
    {
        // Arrange
        var tileId = 2;
        var centerX = 1.0f;
        var centerY = 1.0f;
        var tile = new Tile(tileId, centerX, centerY);

        // Act
        var retrievedId = tile.GetTileId();

        // Assert
        Assert.That(retrievedId, Is.EqualTo(tileId), "Should return correct tile ID.");
    }

    [Test]
    public void GetCenterXPosition_WhenCalled_ReturnsCorrectX()
    {
        // Arrange
        var tileId = 3;
        var centerX = 1.0f;
        var centerY = 2.0f;
        var tile = new Tile(tileId, centerX, centerY);

        // Act
        var retrievedX = tile.GetCenterXPosition();

        // Assert
        Assert.That(retrievedX, Is.EqualTo(centerX), "Should return correct center X position.");
    }

    [Test]
    public void GetCenterYPosition_WhenCalled_ReturnsCorrectY()
    {
        // Arrange
        var tileId = 4;
        var centerX = 2.0f;
        var centerY = 1.0f;
        var tile = new Tile(tileId, centerY, centerY);

        // Act
        var retrievedY = tile.GetCenterYPosition();

        // Assert
        Assert.That(retrievedY, Is.EqualTo(centerY), "Should return correct center Y position.");
    }
}
