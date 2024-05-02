using NUnit.Framework;
using board_games.Model.CommonEntities;
using board_games.Model.SkillIssueBroEntities;

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
        Assert.That(pawn.GetPawnId(), Is.EqualTo(pawnId), "Pawn ID should match.");
        Assert.That(pawn.GetOccupiedTile(), Is.EqualTo(initialTile), "Occupied tile should match.");
        Assert.That(pawn.GetAssociatedPlayer(), Is.EqualTo(associatedPlayer), "Associated player should match.");
    }

    [Test]
    public void ChangeTile_ChangesSuccessfully()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Tile(1, 1.0f, 1.0f);
        var newTile = new Tile(2, 2.0f, 2.0f);
        var pawn = new Pawn(pawnId, initialTile);

        // Act
        pawn.ChangeTile(newTile);

        // Assert
        Assert.That(pawn.GetOccupiedTile(), Is.EqualTo(newTile), "Pawn should occupy the new tile.");
    }

    [Test]
    public void SetAssociatedPlayer_SetsCorrectly()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Tile(1, 1.0f, 1.0f);
        var associatedPlayer = new Player(1, "Player One");
        var pawn = new Pawn(pawnId, initialTile);

        // Act
        pawn.SetAssociatedPlayer(associatedPlayer);

        // Assert
        Assert.That(pawn.GetAssociatedPlayer(), Is.EqualTo(associatedPlayer), "Associated player should match.");
    }

    [Test]
    public void GetAssociatedPlayer_ReturnsCorrectPlayer()
    {
        // Arrange
        var pawnId = 1;
        var initialTile = new Tile(1, 1.0f, 1.0f);
        var associatedPlayer = new Player(1, "Player One");
        var pawn = new Pawn(pawnId, initialTile, associatedPlayer);

        // Act
        var retrievedPlayer = pawn.GetAssociatedPlayer();

        // Assert
        Assert.That(retrievedPlayer, Is.EqualTo(associatedPlayer), "Retrieved player should match.");
    }
}
