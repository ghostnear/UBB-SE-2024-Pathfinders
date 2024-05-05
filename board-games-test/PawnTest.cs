using NUnit.Framework;
using BoardGames.Model.CommonEntities;
using Moq;

[TestFixture]
internal class PawnTests
{
    [Test]
    public void PawnCreation_ValidInputs_CreatesCorrectly()
    {
        var pawnId = 1;
        var mockTile = new Mock<Tile>(1, 1.0f, 1.0f); // Mocking the Tile object
        var mockPlayer = new Mock<Player>(1, "Player One"); // Mocking the Player object

        var pawn = new Pawn(pawnId, mockTile.Object, mockPlayer.Object);

        Assert.That(pawn.GetPawnId(), Is.EqualTo(pawnId), "Should create pawn with correct ID.");
        Assert.That(pawn.GetOccupiedTile(), Is.EqualTo(mockTile.Object), "Should create pawn on correct tile.");
        Assert.That(pawn.GetAssociatedPlayer(), Is.EqualTo(mockPlayer.Object), "Should create pawn with correct player.");
    }


    [Test]
    public void ChangeTile_WhenCalled_ChangesSuccessfully()
    {
        // Arrange
        var pawnId = 1;
        var mockInitialTile = new Mock<Tile>(1, 1.0f, 1.0f);
        var mockNewTile = new Mock<Tile>(2, 2.0f, 2.0f);
        var pawn = new Pawn(pawnId, mockInitialTile.Object);

        // Act
        pawn.ChangeTile(mockNewTile.Object);

        // Assert
        Assert.That(pawn.GetOccupiedTile(), Is.EqualTo(mockNewTile.Object), "Should change pawn's tile successfully.");
    }

    [Test]
    public void SetAssociatedPlayer_WhenCalled_SetsCorrectly()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Mock<Tile>(1, 1.0f, 1.0f);
        var associatedPlayer = new Mock<Player>(1, "Player One");
        var pawn = new Pawn(pawnId, initialTile.Object);

        // Act
        pawn.SetAssociatedPlayer(associatedPlayer.Object);

        // Assert
        Assert.That(pawn.GetAssociatedPlayer(), Is.EqualTo(associatedPlayer.Object), "Should set associated player correctly.");
    }

    [Test]
    public void GetAssociatedPlayer_WhenCalled_ReturnsCorrectPlayer()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Mock<Tile>(1, 1.0f, 1.0f);
        var associatedPlayer = new Mock<Player>(1, "Player One");
        var pawn = new Pawn(pawnId, initialTile.Object, associatedPlayer.Object);

        // Act
        var retrievedPlayer = pawn.GetAssociatedPlayer();

        // Assert
        Assert.That(retrievedPlayer, Is.EqualTo(associatedPlayer.Object), "Should return correct associated player.");
    }
}
