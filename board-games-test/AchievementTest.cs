using NUnit.Framework;
using BoardGames.Model;
using BoardGames.Model.CommonEntities;

[TestFixture]
internal class AchievementTests
{
    [Test]
    public void AchievementCreation_ValidInputs_CreatesCorrectly()
    {
        // Arrange
        var achievementName = "First Win";
        var achievementDescription = "Win your first game.";
        GameCategory gameCategory = 0;

        // Act
        var achievement = new Achievement(achievementName, achievementDescription, gameCategory);

        // Assert
        Assert.That(achievement.GetNameOfAchievement, Is.EqualTo(achievementName));
        Assert.That(achievement.GetDescriptionOfAchievement, Is.EqualTo(achievementDescription));
        Assert.That(achievement.GetAchievementGameCategory, Is.EqualTo(gameCategory));
    }
}
