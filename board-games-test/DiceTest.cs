using NUnit.Framework;
using BoardGames.Model.SkillIssueBroEntities;

namespace BoardGames.Tests.SkillIssueBroEntities
{
    [TestFixture]
    public class DiceTests
    {
        [Test]
        public void RollDice_ShouldReturnValidResult()
        {

            var dice = new Dice();

            int result = dice.RollDice();


            Assert.That(result, Is.InRange(1, 6)); // Assuming result should be between 1 and 6
        }
    }
}
