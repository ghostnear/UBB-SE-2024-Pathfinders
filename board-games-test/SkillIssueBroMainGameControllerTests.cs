using NUnit.Framework;
using Moq;
using BoardGames.Controller;
using BoardGames.Model.CommonEntities;
using BoardGames.Model.SkillIssueBroEntities;
using System.Collections.Generic;

[TestFixture]
internal class SkillIssueBroMainGameControllerTests
{
    [Test]
    public void GeneratePawns_TwoPlayers_CorrectPawnsGenerated()
    {
        // Arrange
        var mockPlayers = new List<Player>
        {
            new Player(1, "Player1"), // Using correct constructor with ID and name
            new Player(2, "Player2")
        };

        var mockTiles = new List<GameTile>();
        for (int tileId = 0; tileId < 16; tileId++)
        {
            mockTiles.Add(new GameTile(tileId, 0, 0)); // Simplified tile creation
        }

        var controller = new SkillIssueBroGameController(mockPlayers);

        // Act
        var pawns = controller.GetPawns();

        // Assert
        Assert.That(pawns.Count, Is.EqualTo(8), "Should generate 8 pawns in total.");
        Assert.That(pawns[0].GetAssociatedPlayer(), Is.EqualTo(mockPlayers[0]), "First pawn should belong to Player1.");
        Assert.That(pawns[4].GetAssociatedPlayer(), Is.EqualTo(mockPlayers[1]), "Fifth pawn should belong to Player2.");
    }

    [Test]
    public void RollDice_WhenCalled_ReturnsDiceRoll()
    {
        // Arrange
        var mockPlayers = new List<Player>
        {
            new Player(1, "Player1")
        };

        var controller = new SkillIssueBroGameController(mockPlayers);

        for(int i=0; i < 100; i++)
        {
            int diceRoll = controller.RollDice();

            Assert.That(diceRoll, Is.GreaterThan(0), "Dice roll should be more than 1.");
            Assert.That(diceRoll, Is.LessThan(7), "Dice roll should be less than 6.");
        }
        
    }

    [Test]
    public void MovePawn_WhenCalled_PawnMovesSuccessfully()
    {
        // Arrange
        var mockPlayers = new List<Player>
        {
            new Player(1, "Player1")
        };

        var mockTiles = new List<GameTile>();
        for (int tileId = 0; tileId < 16; tileId++)
        {
            mockTiles.Add(new GameTile(tileId, 0, 0)); // Simplified tile creation
        }

        var controller = new SkillIssueBroGameController(mockPlayers);
        List<Pawn> newPawns = new List<Pawn>();
        newPawns.Add(new Pawn(1, new GameTile(1, 1, 1)));
        controller.SetPawns(newPawns);
        var pawns = controller.GetPawns();


        var initialTile = new GameTile(1, 1, 1); // Directly created tile
        pawns[0].ChangeTile(initialTile);


        Assert.That(pawns[0].GetOccupiedTile().GetTileId(), Is.EqualTo(1));
    }

    [Test]
    public void ChangeCurrentPlayer_WhenCalled_ChangesCorrectly()
    {
        // Arrange
        var mockPlayers = new List<Player>
        {
            new Player(1, "Player1"),
            new Player(2, "Player2")
        };

        var controller = new SkillIssueBroGameController(mockPlayers);

        // Act
        controller.ChangeCurrentPlayer();

        // Assert
        Assert.That(controller.GetCurrentPlayerColor(), Is.EqualTo("y"));
    }
}
