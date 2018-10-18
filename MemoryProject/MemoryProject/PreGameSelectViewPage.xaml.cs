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
    /// Interaction logic for PreGameSelectViewPage.xaml
    /// </summary>
    public partial class PreGameSelectViewPage : Page
    {
        public PreGameSelectViewPage()
        {
            InitializeComponent();
        }

        public void Play_Game_Grid4(object sender, RoutedEventArgs e)
        {
            string player1Name = player1.Text;
            string player2Name = player2.Text;

            PreGameSelectView.Content = new GameViewPage(player1Name, player2Name);
            // MessageBox.Show("Gameview time");
        }
    }
}
