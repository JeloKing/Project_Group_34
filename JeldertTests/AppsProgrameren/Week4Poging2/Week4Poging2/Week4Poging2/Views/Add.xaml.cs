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
    public partial class Add : ContentPage
    {
        bool ExecuteAdd = false;
        DatabaseManager databaseManager = new DatabaseManager();
        public Add()
        {
            InitializeComponent();
        }

        private void SelectImageClicked(object sender, EventArgs e)
        {

        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddTitle.Text) || string.IsNullOrWhiteSpace(AddYear.Text) || string.IsNullOrWhiteSpace(AddDescription.Text))
            {
                DisplayAlert("Cant insert movie or serie in database", "All fields need to be filled", "Ok");
            }
            else
            {
                databaseManager.AddMovie(AddTitle.Text, AddDescription.Text, AddYear.Text);
            }
        }
    }
}