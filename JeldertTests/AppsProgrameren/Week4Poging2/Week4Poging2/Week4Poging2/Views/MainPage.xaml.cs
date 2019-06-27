using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week4Poging2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private DatabaseManager databaseManger = new DatabaseManager();
        public MainPage()
        {
            InitializeComponent();
            MovieList.ItemsSource = databaseManger.GetAllMovies();
            SerieList.ItemsSource = databaseManger.GetAllSeries();
        }
    }
}
