using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploom.Models;
using Ploom.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusketPage : ContentPage
    {
        public BusketPage()
        {
            InitializeComponent();
            FirnitureService.All();
            BusketLst.ItemsSource = FirnitureService.lst;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckoutPage());
        }
    }
}