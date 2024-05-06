using NUnit.Framework;
using BoardGames.Model.SkillIssueBroEntities;
using System.Collections.Generic;

namespace BoardGames.Tests.SkillIssueBroEntities
{
    [TestFixture]
    public class DiceTests
    {
        [Test]
        public void RollDice_ShouldReturnAllValues()
        {
            var dice = new Dice();
            var results = new HashSet<int>();
            int trials = 1000;  // Number of times the dice is rolled

            for (int i = 0; i < trials; i++)
            {
                results.Add(dice.RollDice());
            }

            // Check if all numbers from 1 to 6 have appeared
            for (int expectedValue = 1; expectedValue <= 6; expectedValue++)
            {
                Assert.That(results, Does.Contain(expectedValue), $"The value {expectedValue} did not appear after {trials} rolls.");
            }
        }
    }
}
