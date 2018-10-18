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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Play_Clicked(object sender, RoutedEventArgs e)
        {
            // Zet de PreGameSelectViewPage als content
            Main.Content = new PreGameSelectViewPage();
        }

        public void Resume_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Resume clicked");
        }

        public void Options_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Options clicked");
        }

        public void Quit_Clicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
