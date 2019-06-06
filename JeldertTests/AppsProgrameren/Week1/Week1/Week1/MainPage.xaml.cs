using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week1
{
    public partial class MainPage : ContentPage
    {
        List<string> names;

        public MainPage()
        { 
            InitializeComponent();
            names = new List<string>();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public void AddClicked(object sender, ClickedEventArgs e)
        {
            if (NameEntry.Text == null)
            {
                return;
            } else
            {
                names.Add(NameEntry.Text);   
            }
        }

        public void ShowClicked(object sender, ClickedEventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new ListPage(names)));
        }
    }
}
