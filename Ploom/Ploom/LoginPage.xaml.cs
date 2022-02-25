using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            WelcomeLbl.Text = "Добро пожаловать в \nFurniture Shop!";
        }

        private async void BackLblTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}