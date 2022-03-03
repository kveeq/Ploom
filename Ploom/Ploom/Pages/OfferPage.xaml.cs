using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploom.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public OfferPage()
        {
            InitializeComponent();
            SuggestionsLst.RefreshCommand = new Command(() =>
            {
                SuggestionsLst.ItemsSource = App.Db.GetImproveOffers();
                SuggestionsLst.IsRefreshing = false; //выключить анимацию обновления 
            });
            SuggestionsLst.ItemsSource = App.Db.GetImproveOffers();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OfferFormPage());
        }
    }
}