namespace board_games.Model.CommonEntities
{
    internal enum GameCategory
    {
        SkillIssueBro = 0, 
        GameOfLife = 1,
    }

    internal class Achievement
    {
        private string _name;
        private string _description;
        private GameCategory _gameCategory;

        public Achievement(string name, string description, GameCategory gameCategory)
        {
            _name = name;
            _description = description;
            _gameCategory = gameCategory;
        }

        public string GetNameOfAchievement()
        {
            return _name;
        }

        public string GetDescriptionOfAchievement()
        {
            return _description;
        }

        public GameCategory GetAchievementGameCategory()
        {
            return _gameCategory;
        }
    }
}