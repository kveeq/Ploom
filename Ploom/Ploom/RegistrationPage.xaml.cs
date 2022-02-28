using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploom.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void BackLbl_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void RegistrateBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                string[] aa = FIOEntry.Text.Split();
                Client client = new Client(aa[0], aa[1], aa[2], TelNumberEntry.Text, EmailEntry.Text, LoginEntry.Text, PassEntry.Text, 0);
                App.Db.SaveClient(client);
                App.client = client;
                await Navigation.PushModalAsync(new NavigationPage(new Page1()));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Не удалось зарегистрироваться" + ex.Message, "Ok");
            }
        }
    }
}