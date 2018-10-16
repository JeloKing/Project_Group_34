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

namespace MemoryGameProject
{
    public class MemoryGrid
    {
        // Make the grid, rows and cols available for use (these are passed by the MainWindow)
        private Grid grid;

        private int rows, cols;

        private ImageSource firstPick;
        private ImageSource secondPick;


        // Primary method of determining grid size and adding images to the grid
        public MemoryGrid(Grid grid, int rows, int cols)
        {
            // Make sure that the computer knows what the grid, rows, and cols are
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;

            // Call the method Initialize grid to make the grid
            InitializeGrid();
            // Call the method addImage to add images to the already made grid
            addImage();

        }

        // Make the specified amount of rows and cols
        private void InitializeGrid()
        {
            for(int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for(int i = 0; i < rows; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private bool clickable = true;

        // Method to add images to the already made grid
        private void addImage()
        {
            List<ImageSource> images = GetImagesList();
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // Make sure the variable ImageBack is seen as a image
                    Image ImageBack = new Image();
               
                    // Set the image for Imageback equal to the specified image between the parantheses (UriKind.Relative makes the program only search the directory)
                    ImageBack.Source = new BitmapImage(new Uri("images/backside.png", UriKind.Relative));

                    // On click execute method Cardclick
                    ImageBack.MouseDown += new MouseButtonEventHandler(CardClick);

                    
                    ImageBack.Tag = images.First();

                    images.RemoveAt(0);

                    // Add the backside image to all rows and cols
                    Grid.SetColumn(ImageBack, col);
                    Grid.SetRow(ImageBack, row);
                    grid.Children.Add(ImageBack);

                }
            }
        }


        // Booleans to check if a first and second picture have been clicked
        bool firstPickSelected = false;
        bool secondPickSelected = false;

        // A list which will be populated with the clicked image
        List<Image> selectedCards = new List<Image>();
        // A list with cards which have been recognized as paired, these will be used to see if the cards which have already been paired are selected again
        List<ImageSource> pairedCards = new List<ImageSource>();

        // Method to show a new image when a card has been clicked
        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;

            // Set a variable for the cardback (could be removed, its only used once)
            ImageSource cardBack = new BitmapImage(new Uri("images/backside.png", UriKind.Relative));

            // If the list pairedCards contains the clicked card Error message and return
            if(pairedCards.Contains(card.Source))
            {
                MessageBox.Show("Card has already been selected");
                return;
            }

            // If firstPickSelected and secondPickSelected equals false set firstPick source, set firstPickSelected to true, 
            // add the selected card to the selectedCard list and disable the ability to click the same card twice
            if(firstPickSelected == false && secondPickSelected == false)
            {
                // Set firstPick source
                firstPick = card.Source;
                // Set firstPickSelected boolean to true
                firstPickSelected = true;

                // Add the selected card to the selectedCards list
                selectedCards.Add(card);
                // Disable the clicked card so it cant be clicked twice
                card.IsEnabled = false;

            } else if(firstPickSelected == true && secondPickSelected == false)
            {
                // Set secondPick card source
                secondPick = card.Source;
                // Set secondPickSelected boolean to true
                secondPickSelected = true;
                // Add the secondPick to the selectedCards list
                selectedCards.Add(card);

                // If firstPick and secondPick sources are not the same
                if (Convert.ToString(firstPick) != Convert.ToString(secondPick))
                {
                    // Display messagebox
                    // MessageBox.Show("not matched");
                    // Set firstPickSelected and secondPickSelected to false so the player can pick 2 cards again
                    /* firstPickSelected = false;
                    secondPickSelected = false;

                    // For each card in selectedCards set the image source equal to the backside again
                    foreach (var item in selectedCards)
                    {
                        // Revert card source back
                        item.Source = cardBack;
                        // Enable the card to be clicked again
                        item.IsEnabled = true;
                    }

                    // Clear the selectedCards list of items 
                    selectedCards.Clear(); */

                    DispatcherTimer timer = null;
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromMilliseconds(1500);
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();

                    // bool IsHitTestVisible = false;

                    // var peter = UIElement.IsHitTestVisibleProperty;

                    grid.IsEnabled = false;

                    void timer_Tick(object time, EventArgs f)
                    {
                        foreach (var item in selectedCards)
                        {
                            // Revert card source back
                            item.Source = cardBack;
                            // Enable the card to be clicked again
                            item.IsEnabled = true;
                        }
                        timer.Stop();
                        grid.IsEnabled = true;
                    }

                    firstPickSelected = false;
                    secondPickSelected = false;
                  
                // Else if firstPick corresponds with secondPick
                } else if (Convert.ToString(firstPick) == Convert.ToString(secondPick))
                {
                    // Show a message
                    // MessageBox.Show("Matched");
                    // Add the firstPick and secondPick to the pairedCards list
                    pairedCards.Add(firstPick);
                    pairedCards.Add(secondPick);

                    // Set the firstPickSelected and secondPickSelected to false so the user can select cards again
                    firstPickSelected = false;
                    secondPickSelected = false;

                    // Clear the selectedCards so the user can select new pairings
                    selectedCards.Clear();
                }
            }
                    
        }


        private List<ImageSource> GetImagesList()
        {
            // Generate a random number
            Random rng = new Random();

            List<ImageSource> images = new List<ImageSource>();
            
            // Loop through 16 times to generate 2 sets of 8 images to add as an image source for the front of a card
            for(int i = 0; i < 16; i++)
            {
                int imageNmr = i % 8 + 1;

                ImageSource source = new BitmapImage(new Uri("images/memory_fe/" + imageNmr + ".png", UriKind.Relative));
                images.Add(source);
            }

            // Returns a shuffeld images list based on the random number generated earlier
            return images.OrderBy(a => rng.Next()).ToList();

        }

    }
}
