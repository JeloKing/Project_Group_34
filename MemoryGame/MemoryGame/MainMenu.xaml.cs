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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            GetHighscores();
        }

        string ThemeSelected;


        /// <summary>
        /// Sets theme to Fire Emblem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Fe_Clicked(object sender, RoutedEventArgs e)
        {
            ThemeSelected = "fire emblem";

            var ImgBrush = new ImageBrush();
            ImgBrush.ImageSource = new BitmapImage(new Uri(@"images/fire emblem/fire emblem background.png", UriKind.Relative));
            MainWindowGrid.Background = ImgBrush;
            HighScoresList.Foreground = Brushes.White;
            HighScoresLine.Foreground = Brushes.White;
        }

        /// <summary>
        /// Sets theme to Star Wars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Sw_Clicked(object sender, RoutedEventArgs e)
        {
            ThemeSelected = "star wars";

            var ImgBrush = new ImageBrush();
            ImgBrush.ImageSource = new BitmapImage(new Uri(@"images/star wars/star wars background.jpg", UriKind.Relative));
            MainWindowGrid.Background = ImgBrush;
            HighScoresList.Foreground = Brushes.White;
            HighScoresLine.Foreground = Brushes.White;
        }

        /// <summary>
        /// Takes players to the Name selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Play_Clicked(object sender, RoutedEventArgs e)
        {
            if (ThemeSelected == null)
            {
                MessageBox.Show("Before continuing please select a theme on the right.");
                return;
            }
            else
            {
                Main.Content = new PreGameSelectViewPage(ThemeSelected);
                MainWindowGrid.Children.Remove(Highscore);
                MainWindowGrid.Children.Remove(Buttons);
                MainWindowGrid.Children.Remove(Themes);
            }
        }

        /// <summary>
        /// Would be used to resume previoulsy saved game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Resume_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hmmm. Hier ging iets fout, probeer 'Start nieuw spel'");
        }

        /// <summary>
        /// Closes current application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Quit_Clicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Sets Highscores to the left of the grid
        /// </summary>
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
                HighScoresList.Text = "Nog geen Highscores!";
            }
        }
    }
}
