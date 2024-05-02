using NUnit.Framework;
using BoardGames.Model.SkillIssueBroEntities;
using BoardGames.Model.CommonEntities;

namespace BoardGames.Tests.SkillIssueBroEntities
{
    [TestFixture]
    public class GameTileTest
    {
        [Test]
        public void Constructor_WhenCalled_ShouldInitializeMembers()
        {

            int tileId = 1;
            int gridRowIndex = 2;
            int gridColumnIndex = 3;

            var gameTile = new GameTile(tileId, gridRowIndex, gridColumnIndex);

            Assert.That(tileId, Is.EqualTo(gameTile.GetTileId()));
            Assert.That(gridColumnIndex, Is.EqualTo(gameTile.GetGridColumnInded()));
            Assert.That(gridRowIndex, Is.EqualTo(gameTile.GetGridRowIndex()));
        }
    }
}
