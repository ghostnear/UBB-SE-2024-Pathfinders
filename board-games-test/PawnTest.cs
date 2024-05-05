using NUnit.Framework;
using BoardGames.Model.CommonEntities;

[TestFixture]
internal class PawnTests
{
    [Test]
    public void PawnCreation_ValidInputs_CreatesCorrectly()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Tile(1, 1.0f, 1.0f);
        var associatedPlayer = new Player(1, "Player One");

        // Act
        var pawn = new Pawn(pawnId, initialTile, associatedPlayer);

        // Assert
        Assert.That(pawn.GetPawnId(), Is.EqualTo(pawnId), "Should create pawn with correct ID.");
        Assert.That(pawn.GetOccupiedTile(), Is.EqualTo(initialTile), "Should create pawn on correct tile.");
        Assert.That(pawn.GetAssociatedPlayer(), Is.EqualTo(associatedPlayer), "Should create pawn with correct player.");
    }

    [Test]
    public void ChangeTile_WhenCalled_ChangesSuccessfully()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Tile(1, 1.0f, 1.0f);
        var newTile = new Tile(2, 2.0f, 2.0f);
        var pawn = new Pawn(pawnId, initialTile);

        // Act
        pawn.ChangeTile(newTile);

        // Assert
        Assert.That(pawn.GetOccupiedTile(), Is.EqualTo(newTile), "Should change pawn's tile successfully.");
    }

    [Test]
    public void SetAssociatedPlayer_WhenCalled_SetsCorrectly()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Tile(1, 1.0f, 1.0f);
        var associatedPlayer = new Player(1, "Player One");
        var pawn = new Pawn(pawnId, initialTile);

        // Act
        pawn.SetAssociatedPlayer(associatedPlayer);

        // Assert
        Assert.That(pawn.GetAssociatedPlayer(), Is.EqualTo(associatedPlayer), "Should set associated player correctly.");
    }

    [Test]
    public void GetAssociatedPlayer_WhenCalled_ReturnsCorrectPlayer()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Tile(1, 1.0f, 1.0f);
        var associatedPlayer = new Player(1, "Player One");
        var pawn = new Pawn(pawnId, initialTile, associatedPlayer);

        // Act
        var retrievedPlayer = pawn.GetAssociatedPlayer();

        // Assert
        Assert.That(retrievedPlayer, Is.EqualTo(associatedPlayer), "Should return correct associated player.");
    }
}
