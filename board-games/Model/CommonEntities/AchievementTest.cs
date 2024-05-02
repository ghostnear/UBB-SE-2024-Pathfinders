﻿using NUnit.Framework;
using board_games.Model;
using board_games.Model.CommonEntities;

[TestFixture]
internal class AchievementTests
{
    [Test]
    public void AchievementCreation_ValidInputs_CreatesCorrectly()
    {
        // Arrange
        var achievementId = 1;
        var achievementName = "First Win";
        var achievementDescription = "Win your first game.";
        GameCategory gameCategory = 0;


        // Act
        var achievement = new Achievement(achievementId, achievementName, achievementDescription,gameCategory);

        // Assert
        Assert.That(achievement.GetAchievementId, Is.EqualTo(achievementId));
        Assert.That(achievement.GetNameOfAchievement, Is.EqualTo(achievementName));
        Assert.That(achievement.GetDescriptionOfAchievement, Is.EqualTo(achievementDescription));
        Assert.That(achievement.GetAchievementGameCategory, Is.EqualTo(gameCategory));

    }

    
}
