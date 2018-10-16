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

namespace MemoryGameProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Beschrijf aantal collomen en rijen
        private const int nr_of_cols = 4;
        private const int nr_of_rows = 4;

        // Maak de grid
        MemoryGrid grid;

        public MainWindow()
        {
            InitializeComponent();
            // DataContext = new StartMenuViewModel(this);

            // Roep de class MemoryGrid op om de grid voor het spel te maken, met als variablen het aantal rijen en collomen
            grid = new MemoryGrid(GameGrid, nr_of_rows, nr_of_cols);
        }
    }
}
