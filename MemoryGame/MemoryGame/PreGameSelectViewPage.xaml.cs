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
    /// Interaction logic for PreGameSelectViewPage.xaml
    /// </summary>
    public partial class PreGameSelectViewPage : Page
    {
        public PreGameSelectViewPage(string ThemeSelected)
        {
            InitializeComponent();
            SelectedTheme.Text = ThemeSelected;
        }

        string Player1Name;
        string Player2Name;

        int nr_of_cols;
        int nr_of_rows;

        string themeSelected;
        

        public void Play_Game_Grid4(object sender, RoutedEventArgs e)
        {
            SetPlayerNames();
            themeSelected = SelectedTheme.Text;

            nr_of_cols = 4;
            nr_of_rows = 4;

            PreGameSelectView.Content = new GameViewPage(Player1Name, Player2Name, themeSelected, nr_of_cols, nr_of_rows);
            RemoveBackground();

        }

        public void Play_Game_Grid5(object sender, RoutedEventArgs e)
        {
            SetPlayerNames();
            themeSelected = SelectedTheme.Text;

            nr_of_cols = 5;
            nr_of_rows = 5;

            PreGameSelectView.Content = new GameViewPage(Player1Name, Player2Name, themeSelected, nr_of_cols, nr_of_rows);
            RemoveBackground();
        }

        public void Play_Game_Grid6(object sender, RoutedEventArgs e)
        {
            SetPlayerNames();
            themeSelected = SelectedTheme.Text;

            nr_of_cols = 6;
            nr_of_rows = 6;

            PreGameSelectView.Content = new GameViewPage(Player1Name, Player2Name, themeSelected, nr_of_cols, nr_of_rows);
            RemoveBackground();
        }

        public void SetPlayerNames()
        {
            Player1Name = player1.Text;
            Player2Name = player2.Text;
        }

        public void RemoveBackground()
        {
            PreGameSelectViewPageMainGrid.Children.Remove(GridSelect);
            PreGameSelectViewPageMainGrid.Children.Remove(PlayerNames);
        }
    }
}
