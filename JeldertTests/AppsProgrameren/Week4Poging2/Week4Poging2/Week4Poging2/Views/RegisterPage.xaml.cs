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
    public partial class RegisterPage : ContentPage
    {
        private DatabaseManager databaseManager = new DatabaseManager();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void Register_Clicked(object sender, EventArgs e)
        {
            if (databaseManager.AddUser(EnterUsername.Text, EnterPassword.Text) == true)
            {
                await Navigation.PushAsync(new LoginPage2());
            }
            else
            {
                await DisplayAlert("Acount bestaat al", "Kan acount niet toevoegen", "Ok");
            }
        }
    }
}