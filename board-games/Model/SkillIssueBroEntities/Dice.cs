namespace BoardGames.Model.SkillIssueBroEntities
{
    internal class Dice
    {
        private Random randomNumberGenerator = new Random();
        public int RollDice()
        {
            return randomNumberGenerator.Next(1, 7);
        }
    }
}
