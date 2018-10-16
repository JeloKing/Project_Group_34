using MemoryNavigation.ViewModels;
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

namespace MemoryNavigation.Views
{
    /// <summary>
    /// Interaction logic for StartMenuView.xaml
    /// </summary>
    public partial class StartMenuView : UserControl
    {
        public StartMenuView()
        {
            InitializeComponent();
        }

        // Beschrijf aantal collomen en rijen
        private const int nr_of_cols = 4;
        private const int nr_of_rows = 4;

        // Maak de grid
        GameViewModel grid;

        private void Play_Clicked(object sender, RoutedEventArgs e)
        {
            var startMenu = DataContext as StartMenuViewModel;
            startMenu.StartNewGame();
        }

        private void Resume_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work in progress");
        }

        private void Options_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work in progress");
        }

        private void Quit_Clicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
