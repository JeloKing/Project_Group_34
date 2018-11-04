using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace MemoryGame
{
    public class MemoryGrid
    {
        // Neutral
        public Grid grid;
        public int rows, cols;
        public string ThemeSelected;

        // GetImageList
        int AmountOfCards;

        // CardClick
        bool Player1Turn = true;
        bool Player2Turn = false;
        bool FirstPickSelected = false;
        bool SecondPickSelected = false;

        int Player1Points = 0;
        int Player2Points = 0;

        int ListSize;

        List<Image> SelectedCards = new List<Image>();
        List<ImageSource> PairedCards = new List<ImageSource>();

        public ImageSource FirstPick, SecondPick;

        public TextBlock Player1Score, Player2Score;
        public TextBlock Player1Name, Player2Name;


        /// <summary>
        /// This method Initializes the creation of the grid and adds images to said grid.
        /// It also sets all passed variables so the can be used in the class scope
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="ThemeSelected"></param>
        /// <param name="Player1Score"></param>
        /// <param name="Player2Score"></param>
        /// <param name="Player1Name"></param>
        /// <param name="Player2Name"></param>
        public void MemoryGridInitializer(Grid grid, int rows, int cols, string ThemeSelected, TextBlock Player1Score, TextBlock Player2Score, TextBlock Player1Name, TextBlock Player2Name)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;
            this.ThemeSelected = ThemeSelected;
            this.Player1Score = Player1Score;
            this.Player2Score = Player2Score;
            this.Player1Name = Player1Name;
            this.Player2Name = Player2Name;

            Player1Name.Background = Brushes.Cyan;
            Player2Name.Background = Brushes.White;

            InitializeGrid();
            AddImage();
        }


        /// <summary>
        /// Makes a grid based on the number of passed rows
        /// </summary>
        public void InitializeGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < rows; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        /// <summary>
        /// Adds images to the grid. it also checks if selected grid is 5x5 so it adds a blank card to substitute the middle
        /// </summary>
        public void AddImage()
        {
            List<ImageSource> images = GetImageList();

            if (cols * cols == 25)
            {
                ImageSource BlankCard = new BitmapImage(new Uri("images/blankcard.png", UriKind.Relative));
                images.Insert(12, BlankCard);
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Image ImageBack = new Image();
                    ImageBack.Source = new BitmapImage(new Uri("images/" + ThemeSelected + "/" + ThemeSelected + " backside.png", UriKind.Relative));
                    ImageBack.MouseDown += new MouseButtonEventHandler(CardClick);
                    ImageBack.Tag = images.First();
                    images.RemoveAt(0);

                    if (cols * cols == 25)
                    {
                        if (row == 2 && col == 2)
                        {
                            continue;
                        } else
                        {
                            Grid.SetColumn(ImageBack, col);
                            Grid.SetRow(ImageBack, row);
                            grid.Children.Add(ImageBack);
                        }
                    } else
                    {
                        Grid.SetColumn(ImageBack, col);
                        Grid.SetRow(ImageBack, row);
                        grid.Children.Add(ImageBack);
                    }
                }
            }
        }


        /// <summary>
        /// The event handler that is added to the cards in the AddImage method.
        /// It sets the backside for each card, it also keeps track of player turns, if selected cards are pairs,
        /// adds points to players if selected cards are pairs, and checks if the game has been completed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CardClick(object sender, MouseButtonEventArgs e)
        {
            ListSize = PairedCards.Count();
            AmountOfCards = cols * cols;

            if (cols * cols == 25) AmountOfCards = 24;

            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
            ImageSource cardBack = new BitmapImage(new Uri("images/" + ThemeSelected + "/" + ThemeSelected + " backside.png", UriKind.Relative));

            if (PairedCards.Contains(card.Source)) return;

            if (FirstPickSelected == false && SecondPickSelected == false)
            {
                FirstPick = card.Source;
                FirstPickSelected = true;
                SelectedCards.Add(card);
                card.IsEnabled = false;
            }
            else if (FirstPickSelected == true && SecondPickSelected == false)
            {
                SecondPick = card.Source;
                SecondPickSelected = true;
                SelectedCards.Add(card);

                if (Convert.ToString(FirstPick) != Convert.ToString(SecondPick))
                {
                    DispatcherTimer timer = null;
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromMilliseconds(1500);
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    grid.IsEnabled = false;

                    void timer_Tick(object time, EventArgs f)
                    {
                        foreach (var item in SelectedCards)
                        {
                            item.Source = cardBack;
                            item.IsEnabled = true;
                        }
                        timer.Stop();
                        grid.IsEnabled = true;
                    }
                    FirstPickSelected = false;
                    SecondPickSelected = false;

                    if (Player1Turn == true && Player2Turn == false)
                    {
                        Player1Turn = false;
                        Player2Turn = true;

                        Player1Name.Background = Brushes.White;
                        Player2Name.Background = Brushes.Cyan;
                    }
                    else if (Player1Turn == false && Player2Turn == true)
                    {
                        Player1Turn = true;
                        Player2Turn = false;

                        Player1Name.Background = Brushes.Cyan;
                        Player2Name.Background = Brushes.White;
                    }
                }
                else if (Convert.ToString(FirstPick) == Convert.ToString(SecondPick))
                {
                    PairedCards.Add(FirstPick);
                    PairedCards.Add(SecondPick);
                    FirstPickSelected = false;
                    SecondPickSelected = false;

                    SelectedCards.Clear();

                    if (Player1Turn == true && Player2Turn == false)
                    {
                        Player1Points = Player1Points + 10;
                        Player1Score.Text = Convert.ToString(Player1Points);
                    }
                    else if (Player1Turn == false && Player2Turn == true)
                    {
                        Player2Points = Player2Points + 10;
                        Player2Score.Text = Convert.ToString(Player2Points);
                    }

                    if (ListSize == AmountOfCards - 2)
                    {
                        HighScore highscore = new HighScore();

                        if (Player1Points > Player2Points)
                        {
                            MessageBox.Show("Player 1 wins with: " + Player1Points + " points!");
                            highscore.NewHighScore(Player1Points, Player1Name.Text);
                        }
                        else if (Player2Points > Player1Points)
                        {
                            MessageBox.Show("Player 1 wins with: " + Player2Points + " points!");
                            highscore.NewHighScore(Player2Points, Player2Name.Text);
                        }
                        else if (Player1Points == Player2Points)
                        {
                            MessageBox.Show("Its a draw!");
                        }

                        if (MessageBox.Show("Exit game?", "", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                        {
                            return;
                        } else
                        {
                            Application.Current.Shutdown();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method used to make a list of randomly sorted images.
        /// These images are take from a map based on the theme selected in the MainMenu
        /// </summary>
        /// <returns></returns>
        public List<ImageSource> GetImageList()
        {
            Random rng = new Random();
            List<ImageSource> images = new List<ImageSource>();
            AmountOfCards = cols * cols;

            if (cols * cols == 25)
            {
                AmountOfCards = 24;
            }

            for (int i = 0; i < AmountOfCards; i++)
            {
                int imageNmr = i % 8 + 1;

                if (cols * cols == 25) imageNmr = i % 12 + 1;
                if (cols * cols == 36) imageNmr = i % 18 + 1;

                ImageSource source = new BitmapImage(new Uri("images/" + ThemeSelected + "/" + imageNmr + ".png", UriKind.Relative));
                images.Add(source);
            }
            return images.OrderBy(a => rng.Next()).ToList();
        }

        /// <summary>
        /// Saves Information about current game to Xmlfile
        /// </summary>
        public void SaveGame()
        {
            MemorySaveGameInfo info = new MemorySaveGameInfo();
            info.Player1Name = Player1Name.Text;
            info.Player2Name = Player2Name.Text;
            info.Player1Score = Player1Score.Text;
            info.Player2Score = Player2Score.Text;
            info.ThemeSelected = ThemeSelected;

            SaveMemoryGame.SaveData(info, "MemorySaveGame.xml");
            MessageBox.Show("MemoryGame Saved!");

            grid.Children.Remove(grid);
        }
    }
}
