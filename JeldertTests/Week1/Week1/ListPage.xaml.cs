using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage(List<string> mainNameList)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);

            nameList.ItemsSource = mainNameList;
        }
    }
}