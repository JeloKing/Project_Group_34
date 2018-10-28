using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
using System.Xml.Serialization;

namespace MemoryProject
{
    /// <summary>
    /// Interaction logic for GameViewPage.xaml
    /// </summary>
    public partial class GameViewPage : Page
    {
        MemoryGrid grid;

        public GameViewPage(string player1input, string player2input, string themeSelected, int nr_of_cols, int nr_of_rows)
        {
            InitializeComponent();

            selectedTheme.Text = themeSelected;

            player1name.Text = player1input;
            player2name.Text = player2input;

            TextBlock player1points = player1score;
            TextBlock player2points = player2score;

            TextBlock player1naam = player1name;
            TextBlock player2naam = player2name;

            nrOfCols.Text = Convert.ToString(nr_of_cols);
            nrOfRows.Text = Convert.ToString(nr_of_rows);

            grid = new MemoryGrid();
            grid.MemoryGridInitializer(GameGrid, nr_of_rows, nr_of_cols, player1points, player2points, player1naam, player2naam, themeSelected);
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

            player1name.Background = Brushes.Green;
            player2name.Background = Brushes.White;

            int nr_of_cols = Convert.ToInt32(nrOfCols.Text);
            int nr_of_rows = Convert.ToInt32(nrOfRows.Text);

            GameGrid.ColumnDefinitions.Clear();
            GameGrid.RowDefinitions.Clear();

            grid = new MemoryGrid();
            grid.MemoryGridInitializer(GameGrid, nr_of_rows, nr_of_cols, player1points, player2points, player1naam, player2naam, themeSelected);
        }

        public void SaveQuitGame(object sender, RoutedEventArgs e)
        {
            UIElement element = GameViewPageGrid;
            string strXAML = System.Windows.Markup.XamlWriter.Save(element);
            string filename = "MemorySaveGame.xaml";

            using(System.IO.FileStream fs = System.IO.File.Create(filename))
            {
                using(System.IO.StreamWriter streamwriter = new System.IO.StreamWriter(fs))
                {
                    streamwriter.Write(strXAML);
                }
            }

            MessageBox.Show("MemoryGame Saved!");

            Application.Current.Shutdown();
        }
    }
}
