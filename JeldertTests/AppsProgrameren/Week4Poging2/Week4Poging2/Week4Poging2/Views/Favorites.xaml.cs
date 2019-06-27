using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week4Poging2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favorites : ContentPage
    {
        private DatabaseManager databaseManger = new DatabaseManager();
        public Favorites()
        {
            InitializeComponent();
            MovieList.ItemsSource = databaseManger.GetAllMovies();
            SerieList.ItemsSource = databaseManger.GetAllSeries();
        }
    }
}