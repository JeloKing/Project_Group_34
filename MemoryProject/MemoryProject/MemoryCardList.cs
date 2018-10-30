using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MemoryProject
{
    public class MemoryCardList
    {

        public List<ImageSource> GetImageList(int cols, int amountOfCards, string themeSelected)
        {
            Random rng = new Random();

            List<ImageSource> images = new List<ImageSource>();

            amountOfCards = cols * cols;

            if (cols * cols == 25)
            {
                amountOfCards = 24;
            }


            // Loop through 16 times to generate 2 sets of 8 images to add as an image source for the front of a card
            for (int i = 0; i < amountOfCards; i++)
            {
                int imageNmr = i % 8 + 1;

                if (cols * cols == 25)
                {
                    imageNmr = i % 12 + 1;
                }

                if (cols * cols == 36)
                {
                    imageNmr = i % 18 + 1;
                }

                ImageSource source = new BitmapImage(new Uri("images/" + themeSelected + "/" + imageNmr + ".png", UriKind.Relative));
                images.Add(source);
            }

            // Returns a shuffeld images list based on the random number generated earlier
            return images.OrderBy(a => rng.Next()).ToList();
        }

    }
}
