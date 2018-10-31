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
            // MessageBox.Show("Theme: " + ThemeSelected + " Selected");

            var imgBrush = new ImageBrush();
            imgBrush.ImageSource = new BitmapImage(new Uri(@"images/fire emblem/fire emblem background.png", UriKind.Relative));
            MainWindowGrid.Background = imgBrush;
            HighScoresList.Foreground = Brushes.White;
            HighScoresLine.Foreground = Brushes.White;
        }

        public void Sw_Clicked(object sender, RoutedEventArgs e)
        {
            ThemeSelected = "star Wars";
            // MessageBox.Show("Theme: " + ThemeSelected + " Selected");

            var imgBrush = new ImageBrush();
            imgBrush.ImageSource = new BitmapImage(new Uri(@"images/star wars/star wars background.jpg", UriKind.Relative));
            MainWindowGrid.Background = imgBrush;
            HighScoresList.Foreground = Brushes.White;
            HighScoresLine.Foreground = Brushes.White;
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
                MainWindowGrid.Children.Remove(Highscore);
                MainWindowGrid.Children.Remove(Buttons);
                MainWindowGrid.Children.Remove(Themes);
            }     
        }

        public void Resume_Clicked(object sender, RoutedEventArgs e)
        {
            string filename = "MemorySaveGame.xaml";

            using (System.IO.FileStream fs = System.IO.File.Open(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                Main.Content = System.Windows.Markup.XamlReader.Load(fs) as UIElement;
            }

            MainWindowGrid.Children.Remove(Highscore);
            MainWindowGrid.Children.Remove(Buttons);
            MainWindowGrid.Children.Remove(Themes);
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
