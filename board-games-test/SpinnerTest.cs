using NUnit.Framework;
using BoardGames.Model.GameOfLife;
using System;

namespace BoardGames.Tests.GameOfLife
{
    [TestFixture]
    public class SpinnerTest
    {
        [Test]
        public void Constructor_WhenCalled_ShouldInitializeRandomizer()
        {
            var spinner = new Spinner();

            Assert.That(spinner, Is.Not.Null);
        }

        [Test]
        public void RollSpinner_ShouldReturnValidResult()
        {
            var spinner = new Spinner();

            int result = spinner.RollSpinner();

            Assert.That(result, Is.InRange(1, 10));
        }

        [Test]
        public void RollSpinner_ShouldReturnCorrectResultBasedOnProbabilities()
        {
            // Arrange
            var spinner = new Spinner();
            int[] count = new int[10];

            const int iterations = 100000;
            for (int i = 0; i < iterations; i++)
            {
                int result = spinner.RollSpinner();
                count[result - 1]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                double expectedProbability = Spinner.ResultProbabilitiesAsPercentages[i + 1] / 100.0;
                double actualProbability = (double)count[i] / iterations;
                Assert.That(actualProbability, Is.EqualTo(expectedProbability).Within(0.01));
            }
        }
    }
}
