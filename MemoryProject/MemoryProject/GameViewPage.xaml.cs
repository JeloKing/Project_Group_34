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

namespace MemoryProject
{
    /// <summary>
    /// Interaction logic for GameViewPage.xaml
    /// </summary>
    public partial class GameViewPage : Page
    {

        private const int nr_of_cols = 4;
        private const int nr_of_rows = 4;

        MemoryGrid grid;


        public GameViewPage(string player1input, string player2input, string themeSelected)
        {
            InitializeComponent();

            selectedTheme.Text = themeSelected;

            player1name.Text = player1input;
            player2name.Text = player2input;

            TextBlock player1points = player1score;
            TextBlock player2points = player2score;

            TextBlock player1naam = player1name;
            TextBlock player2naam = player2name;

            // string player1points = player1score.Text;

            // int player1points = Convert.ToInt32(player1score.Text);
            // int player2points = Convert.ToInt32(player2score.Text);

            // MessageBox.Show(player1points);

            grid = new MemoryGrid(GameGrid, nr_of_rows, nr_of_cols, player1points, player2points, player1naam, player2naam, themeSelected);
        }

        public void ResetGame(object sender, RoutedEventArgs e)
        {
            string themeSelected = selectedTheme.Text;

            player1score.Text = "0";
            player2score.Text = "0";

            TextBlock player1points = player1score;
            TextBlock player2points = player2score;

            TextBlock player1naam = player1name;
            TextBlock player2naam = player2name;

            GameGrid.ColumnDefinitions.Clear();
            GameGrid.RowDefinitions.Clear();

            grid = new MemoryGrid(GameGrid, nr_of_rows, nr_of_cols, player1points, player2points, player1naam, player2naam, themeSelected);
        }
    }
}
