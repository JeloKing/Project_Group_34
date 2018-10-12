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

namespace MemoryGameProject
{
    public class MemoryGrid
    {
        // Make the grid, rows and cols available for use (these are passed by the MainWindow)
        private Grid grid;

        private int rows, cols;

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


        // Method to show a new image when a card has been clicked
        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;

            MessageBox.Show(Convert.ToString(front));
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

                ImageSource source = new BitmapImage(new Uri("images/" + imageNmr + ".jpg", UriKind.Relative));
                images.Add(source);
            }

            // Returns a shuffeld images list based on the random number generated earlier
            return images.OrderBy(a => rng.Next()).ToList();

        }

    }
}
