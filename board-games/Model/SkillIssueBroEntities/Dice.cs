﻿namespace BoardGames.Model.SkillIssueBroEntities
{
    internal class Dice
    {
        private Random _randomizer = new Random();
        
        public int RollDice()
        {
            return _randomizer.Next(1, 7);
        }
    }
}
