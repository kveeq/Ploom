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
            bool state = false;
            foreach (var item in App.Db.GetClients())
            {
                if (item.Login == LoginLbl.Text)
                {
                    if (item.Password == PassLbl.Text)
                    {
                        state = true;
                        App.client = item;
                        await Navigation.PushModalAsync(new NavigationPage(new Page1()));

                    }
                }
            }
            if (!state)
                await DisplayAlert("Error", "Неправильный пароль или логин", "Ok");
        }
    }
}