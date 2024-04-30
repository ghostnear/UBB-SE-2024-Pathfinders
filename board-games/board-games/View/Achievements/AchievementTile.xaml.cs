using board_games.Model.CommonEntities;
using System.Windows;
using System.Windows.Controls;

namespace board_games.View.Achievements
{
    /// <summary>
    /// Interaction logic for AchievementTile.xaml
    /// </summary>
    public partial class AchievementTile : UserControl
    {
        public AchievementTile()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty AchievementProperty =
            DependencyProperty.Register(
                "Achievement",
                typeof(Achievement),
                typeof(AchievementTile),
                new PropertyMetadata(null, OnAchievementChanged));

        internal Achievement Achievement
        {
            get { return (Achievement)GetValue(AchievementProperty); }
            set { SetValue(AchievementProperty, value); }
        }

        private static void OnAchievementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as AchievementTile;
            control.UpdateText();
        }

        private void UpdateText()
        {
            if (Achievement != null)
            {
                title.Text = Achievement.GetNameOfAchievement();
                description.Text = Achievement.GetDescriptionOfAchievement();
                game.Text = Achievement.GetAchievementGameCategory().ToString();
            }
        }

    }
}