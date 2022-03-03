using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferFormPage : ContentPage
    {
        public OfferFormPage()
        {
            InitializeComponent();
            FIOLbl.Text = $"{App.client.Surname} {App.client.Name} {App.client.Patronymic}";
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OfferBtn_Clicked(object sender, EventArgs e)
        {
            App.Db.SaveImprove(new Models.ImproveOffer(App.client.Id, TextOffer.Text));
            await Navigation.PopAsync();
        }
    }
}