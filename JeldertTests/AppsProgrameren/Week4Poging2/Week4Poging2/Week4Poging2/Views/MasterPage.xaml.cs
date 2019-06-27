using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Poging2.MenuItems;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week4Poging2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        List<MasterPageItem> items = new List<MasterPageItem>();
        public MasterPage()
        {
            InitializeComponent();
            AddingItems();
            NavigationDrawerList.ItemsSource = items;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));
        }

        private void NavigationDrawerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

        private void AddingItems()
        {
            MasterPageItem MoviesAndSeries = new MasterPageItem();
            MoviesAndSeries.Title = "Movies and series";
            MoviesAndSeries.TargetType = typeof(MainPage);
            MasterPageItem AddPage = new MasterPageItem();
            AddPage.Title = "Add";
            AddPage.TargetType = typeof(Add);
            MasterPageItem Favorites = new MasterPageItem();
            Favorites.Title = "Favorites";
            Favorites.TargetType = typeof(Favorites);
            items.Add(MoviesAndSeries);
            items.Add(AddPage);
            items.Add(Favorites);
        }
    }
}