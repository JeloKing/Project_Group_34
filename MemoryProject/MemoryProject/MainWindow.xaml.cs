using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

            StreamReader sr = new StreamReader("HighScores.txt");
            HighScoresList.Text = sr.ReadToEnd();
            sr.Close();
        }

        string ThemeSelected;

        public void Fe_Clicked(object sender, RoutedEventArgs e)
        {
            ThemeSelected = "fire emblem";
            MessageBox.Show("Theme: " + ThemeSelected + " Selected");
        }

        public void Sw_Clicked(object sender, RoutedEventArgs e)
        {
            ThemeSelected = "star Wars";
            MessageBox.Show("Theme: " + ThemeSelected + " Selected");
        }


        public void Play_Clicked(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(ThemeSelected);

            if(ThemeSelected == null)
            {
                MessageBox.Show("Please select a theme on the right to continue");
                return;
            } else
            {
                // Zet de PreGameSelectViewPage als content
                Main.Content = new PreGameSelectViewPage(ThemeSelected);
            }     
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
