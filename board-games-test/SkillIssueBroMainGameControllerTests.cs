using NUnit.Framework;
using Moq;
using BoardGames.Controller;
using BoardGames.Model.CommonEntities;
using BoardGames.Model.SkillIssueBroEntities;
using System.Collections.Generic;
using Board_games.Model.Interfaces;
using BoardGames.View.SkillIssueBro.Pawns;

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

    [Test]
    public void DeterminePawnIdBasedOnColumnAndRow_PawnExists_ReturnsPawnId()
    {
        // Arrange
        var mockPawn1 = new Mock<IPawn>();
        mockPawn1.Setup(p => p.GetPawnId()).Returns(1);
        var mockTile1 = new Mock<ITile>();
        mockTile1.Setup(t => t.GetCenterXPosition()).Returns(1.0f);
        mockTile1.Setup(t => t.GetCenterYPosition()).Returns(1.0f);
        mockPawn1.Setup(p => p.GetOccupiedTile()).Returns(mockTile1.Object);

        var mockPawn2 = new Mock<IPawn>();
        mockPawn2.Setup(p => p.GetPawnId()).Returns(2);
        var mockTile2 = new Mock<ITile>();
        mockTile2.Setup(t => t.GetCenterXPosition()).Returns(2.0f);
        mockTile2.Setup(t => t.GetCenterYPosition()).Returns(2.0f);
        mockPawn2.Setup(p => p.GetOccupiedTile()).Returns(mockTile2.Object);

        var mockGamePawns = new List<IPawn> { mockPawn1.Object, mockPawn2.Object };
        var controller = new SkillIssueBroGameController(new List<Player>{
            new Player(1, "Player1"),
            new Player(2, "Player2")
        });

        // Act
        int pawnId = controller.DeterminePawnIdBasedOnColumnAndRow(1, 1);

        // Assert
        Assert.That(pawnId, Is.EqualTo(23), "Should return the pawn ID for the specified column and row.");
    }

    [Test]
    public void DeterminePawnIdBasedOnColumnAndRow_PawnDoesNotExist_ReturnsMinusOne()
    {
        // Arrange
        var mockPawn1 = new Mock<IPawn>();
        mockPawn1.Setup(p => p.GetPawnId()).Returns(1);
        var mockTile1 = new Mock<ITile>();
        mockTile1.Setup(t => t.GetCenterXPosition()).Returns(1.0f);
        mockTile1.Setup(t => t.GetCenterYPosition()).Returns(1.0f);
        mockPawn1.Setup(p => p.GetOccupiedTile()).Returns(mockTile1.Object);

        var mockPawn2 = new Mock<IPawn>();
        mockPawn2.Setup(p => p.GetPawnId()).Returns(2);
        var mockTile2 = new Mock<ITile>();
        mockTile2.Setup(t => t.GetCenterXPosition()).Returns(2.0f);
        mockTile2.Setup(t => t.GetCenterYPosition()).Returns(2.0f);
        mockPawn2.Setup(p => p.GetOccupiedTile()).Returns(mockTile2.Object);

        var mockGamePawns = new List<IPawn> { mockPawn1.Object, mockPawn2.Object };
        var controller = new SkillIssueBroGameController(new List<Player>
        {
             new Player(1, "Player1"),
              new Player(2, "Player2")
        });

        // Act
        int pawnId = controller.DeterminePawnIdBasedOnColumnAndRow(3, 3);

        // Assert
        Assert.That(pawnId,Is.EqualTo(-1), "Should return -1 when no pawn exists for the specified column and row.");
    }
    [Test]
    public void FindEmptyHomeTileInRange_NoOccupiedTilesInRange_ReturnsTile()
    {
        // Arrange
        var mockTile1 = new Mock<ITile>();
        mockTile1.Setup(t => t.GetTileId()).Returns(1);

        var mockTile2 = new Mock<ITile>();
        mockTile2.Setup(t => t.GetTileId()).Returns(2);

        var mockTile3 = new Mock<ITile>();
        mockTile3.Setup(t => t.GetTileId()).Returns(3);

        var mockTile4 = new Mock<ITile>();
        mockTile4.Setup(t => t.GetTileId()).Returns(4);

        var mockGameTiles = new List<ITile> { mockTile1.Object, mockTile2.Object, mockTile3.Object, mockTile4.Object };
        var mockGamePawns = new List<Pawn>
        {
            new Pawn(1, mockTile3.Object, new Player(1, "Player1"))
        };
        var controller = new SkillIssueBroGameController(new List<Player>
        {
             new Player(1, "Player1"),
              new Player(2, "Player2")
        });
        controller.SetPawns(mockGamePawns);

        // Act
        Tile emptyTile = controller.FindEmptyHomeTileInRange(5, 10);

        // Assert
        Assert.That(emptyTile, Is.Not.Null, "Should return a tile from the range");
    }

    [Test]
    public void FindEmptyHomeTileInRange_AllTilesOccupiedInRange_ThrowsException()
    {
        // Arrange
        var mockTile1 = new Mock<ITile>();
        mockTile1.Setup(t => t.GetTileId()).Returns(1);

        var mockTile2 = new Mock<ITile>();
        mockTile2.Setup(t => t.GetTileId()).Returns(2);

        var mockTile3 = new Mock<ITile>();
        mockTile3.Setup(t => t.GetTileId()).Returns(3);

        var mockTile4 = new Mock<ITile>();
        mockTile4.Setup(t => t.GetTileId()).Returns(4);

        var mockGameTiles = new List<ITile> { mockTile1.Object, mockTile2.Object, mockTile3.Object, mockTile4.Object };
        
        var controller = new SkillIssueBroGameController(new List<Player>{new Player(1, "Player1"),
            new Player(2, "Player2") });
        var mockGamePawns = new List<Pawn>
        {
            new Pawn(1, mockTile3.Object, new Player(1, "Player1"))
        };
        controller.SetPawns(mockGamePawns);

        
        Assert.Throws<Exception>(() => controller.FindEmptyHomeTileInRange(3, 3),"Should throw an exception when all tiles within the specified range are occupied.");
    }
}
