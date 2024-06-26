﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using BoardGames.View.SkillIssueBro.Board;

namespace BoardGames.View.SkillIssueBro.Menus
{
    /// <summary>
    /// Interaction logic for SkillIssueBroNumberPlayers.xaml
    /// </summary>
    public partial class SkillIssueBroNumberPlayers : Page
    {
        public SkillIssueBroNumberPlayers()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SkillIssueBroMainMenu());
        }

        private void OnChooseTwoPlayers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GameBoardWindow());
        }

        private void OnChooseThreePlayers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GameBoardWindow());
        }

        private void OnChooseFourPlayers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GameBoardWindow());
        }
    }
}
