using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetHighscores();
        }

        string ThemeSelected;

        public void Fe_Clicked(object sender, RoutedEventArgs e)
        {
            ThemeSelected = "fire emblem";

            var ImgBrush = new ImageBrush();
            ImgBrush.ImageSource = new BitmapImage(new Uri(@"images/fire emblem/fire emblem background.png", UriKind.Relative));
            MainWindowGrid.Background = ImgBrush;
            HighScoresList.Foreground = Brushes.White;
            HighScoresLine.Foreground = Brushes.White;
        }

        public void Sw_Clicked(object sender, RoutedEventArgs e)
        {
            ThemeSelected = "star wars";

            var ImgBrush = new ImageBrush();
            ImgBrush.ImageSource = new BitmapImage(new Uri(@"images/star wars/star wars background.jpg", UriKind.Relative));
            MainWindowGrid.Background = ImgBrush;
            HighScoresList.Foreground = Brushes.White;
            HighScoresLine.Foreground = Brushes.White;
        }

        public void Play_Clicked(object sender, RoutedEventArgs e)
        {
            if (ThemeSelected == null)
            {
                MessageBox.Show("Before continuing please select a theme on the right.");
                return;
            } else
            {
                Main.Content = new PreGameSelectViewPage(ThemeSelected);
                MainWindowGrid.Children.Remove(Highscore);
                MainWindowGrid.Children.Remove(Buttons);
                MainWindowGrid.Children.Remove(Themes);
            }
        }

        public void Resume_Clicked(object sender, RoutedEventArgs e)
        {
            return;
        }

        public void Quit_Clicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void GetHighscores()
        {
            string Filename = "HighScores.txt";

            if (File.Exists(Filename))
            {
                StreamReader sr = new StreamReader("HighScores.txt");
                HighScoresList.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                return;
            }   
        }


    }
}
