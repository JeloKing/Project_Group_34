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

namespace MemoryGame
{
    /// <summary>
    /// Interaction logic for GameViewPage.xaml
    /// </summary>
    public partial class GameViewPage : Page
    {
        MemoryGrid grid = new MemoryGrid();

        string Player1Name;
        string Player2Name;
        string ThemeSelected;
        int nr_of_cols;
        int nr_of_rows;
        
        public GameViewPage(string Player1Name, string Player2Name, string ThemeSelected, int nr_of_cols, int nr_of_rows)
        {
            InitializeComponent();
            this.Player1Name = Player1Name;
            this.Player2Name = Player2Name;
            this.ThemeSelected = ThemeSelected;
            this.nr_of_cols = nr_of_cols;
            this.nr_of_rows = nr_of_rows;

            selectedTheme.Text = ThemeSelected;

            SetPlayerInformation();

            grid.MemoryGridInitializer(GameGrid, nr_of_rows, nr_of_cols, ThemeSelected, player1score, player2score, player1name, player2name);
        }

        public void ResetGame(object sender, RoutedEventArgs e)
        {
            string themeSelected = selectedTheme.Text;
            player1score.Text = "0";
            player2score.Text = "0";

            player1name.Background = Brushes.Cyan;
            player2name.Background = Brushes.White;

            GameGrid.ColumnDefinitions.Clear();
            GameGrid.RowDefinitions.Clear();

            grid.MemoryGridInitializer(GameGrid, nr_of_rows, nr_of_cols, themeSelected, player1score, player2score, player1name, player2name);
        }

        public void SaveQuitGame(object sender, RoutedEventArgs e)
        {

        }

        public void SetPlayerInformation()
        {
            player1name.Text = Player1Name;
            player2name.Text = Player2Name;
        }
    }
}
