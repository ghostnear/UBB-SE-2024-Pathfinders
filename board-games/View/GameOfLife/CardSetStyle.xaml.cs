﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BoardGames.View.GameOfLife
{
    /// <summary>
    /// Interaction logic for CardSetStyle.xaml
    /// </summary>
    public partial class CardSetStyle : Page
    {
        private bool isPicture1Displayed = true;
        private BitmapImage _cardSetLight;
        private BitmapImage _cardSetDark;
        public CardSetStyle()
        {
            InitializeComponent();
            _cardSetLight = new BitmapImage(new Uri("../../Resources/cardset_light.png", UriKind.Relative));
            _cardSetDark = new BitmapImage(new Uri("../../Resources/cardset_dark.png", UriKind.Relative));

            DisplayCurrentPicture();
        }

        private void DisplayCurrentPicture()
        {
            if (isPicture1Displayed)
            {
                ImageControl.Source = _cardSetLight;
            }
            else
            {
                ImageControl.Source = _cardSetDark;
            }
        }

        private void ArrowLeftButton_Click(object sender, RoutedEventArgs e)
        {
            isPicture1Displayed = !isPicture1Displayed;

            DisplayCurrentPicture();
        }

        private void ArrowRightButton_Click(object sender, RoutedEventArgs e)
        {
            isPicture1Displayed = !isPicture1Displayed;

            DisplayCurrentPicture();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Settings());
        }
    }
}
