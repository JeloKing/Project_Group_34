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
    public partial class LoginPage2 : ContentPage
    {
        private DatabaseManager databaseManager = new DatabaseManager();
        public LoginPage2()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void LoginCliked(object sender, EventArgs e)
        {
            if (databaseManager.DoesAccountExist(UsernameEntry.Text, PasswordEntry.Text) == true)
            {
                // await Navigation.PushAsync(new MainPage());
                await Navigation.PushAsync(new MasterPage());

            }
            else
            {
                await DisplayAlert("Acount bestaat niet", "Het acount bestaat niet", "Jammer");
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}