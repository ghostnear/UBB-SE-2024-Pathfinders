using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using board_games.Model.GameOfLife;
using board_games.Model.GameOfLife.Cards;
using board_games.Model.GameOfLife.Cards.Ability;

namespace board_games
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            BadCardNegationAbility ability = new BadCardNegationAbility(CardType.Health, 10, 5);
            Debug.Assert(ability.TurnsLeft == 10);
            Debug.Assert(ability.cooldown == 5);
            Debug.Assert(ability.GetTypeToNegate() == CardType.Health);

            IAbility teleportAbility = new TeleportAbility();
            Debug.Assert(TeleportAbility.Cooldown == 1);

            InitializeComponent();
        }
    }
}