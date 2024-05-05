using NUnit.Framework;
using BoardGames.Model.GameOfLife;
using System;

[TestFixture]
public class SpinnerTests
{
    [Test]
    public void Constructor_WhenCalled_InitializesRandomizer()
    {
        // Arrange
        var spinner = new Spinner();

        // Assert
        Assert.That(spinner, Is.Not.Null);
    }

    [Test]
    public void RollSpinner_ReturnsValidResult()
    {
        // Arrange
        var spinner = new Spinner();

        // Act
        int result = spinner.RollSpinner();

        // Assert
        Assert.That(result, Is.InRange(1, 10));
    }

    [Test]
    public void RollSpinner_ReturnsCorrectResultBasedOnProbabilities()
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

        // Assert
        for (int i = 0; i < count.Length; i++)
        {
            double expectedProbability = Spinner.ResultProbabilitiesAsPercentages[i + 1] / 100.0;
            double actualProbability = (double)count[i] / iterations;
            Assert.That(actualProbability, Is.EqualTo(expectedProbability).Within(0.1));
        }
    }
}
