using board_games.Controller;
using board_games.Model.CommonEntities;
using board_games.Model.SkillIssueBroEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace board_games.View.SkillIssueBro.Board
{
    /// <summary>
    /// Interaction logic for GameBoardWindow.xaml
    /// </summary>
    public partial class GameBoardWindow : UserControl
    {
        // temporary hardcoded players
        private List<Player> _players = new List<Player> { 
            new Player(1, "Egg"),
            new Player(2, "Mario"),
            new Player(3, "Gigi"),
            new Player(4, "Flower")
        };


        private SkillIssueBroMainGameController skillIssueBroController;
        public GameBoardWindow()
        {
            InitializeComponent();
            Loaded += GameBoardWindow_Loaded;
        }

        private void GameBoardWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // create the controller when the window is loaded
            skillIssueBroController = new SkillIssueBroMainGameController(_players);
            SpawnPawns(skillIssueBroController.GetPawns());
        }

        private void SpawnPawns(List<Pawn> pawnsToSpawn)
        {
            // blue and yellow spawned regardless
            for(int i=0; i<4;i++)
            {
                Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                gameBoard.AddBluePawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
            }

            for(int i = 4; i < 8; i++)
            {
                Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                gameBoard.AddYellowPawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
            }

            // green if player count > 2
            if(_players.Count > 2)
            {
                for(int i=8; i<12; i++)
                {
                    Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                    gameBoard.AddGreenPawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
                }
            }
            // red if player count > 3 
            if (_players.Count > 3)
            {
                for(int i=12; i < 16; i++)
                {
                    Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                    gameBoard.AddRedPawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
                }
            }
        }

    }
}
