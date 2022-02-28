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

        private void RegistrateBtn_Clicked(object sender, EventArgs e)
        {
            Client client = new Client();
            App.Db.SaveClient(client);
        }
    }
}