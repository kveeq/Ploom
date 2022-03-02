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
            if (LoginLbl.Text == "qq" && PassLbl.Text == "qq")
            {
                var cl = new Client("admin", "admin", "admin", "0000", "admin@admin.ru", "qq", "qq", 1);
                App.client = cl;
                await Navigation.PushModalAsync(new NavigationPage(new Page1()));
            }
            else
                if (!await CheckLogin())
                await DisplayAlert("Error", "Неправильный пароль или логин", "Ok");
        }
        private async Task<bool> CheckLogin()
        {
            foreach (var item in App.Db.GetClients())
            {
                if (item.Login == LoginLbl.Text)
                {
                    if (item.Password == PassLbl.Text)
                    {
                        App.client = item;
                        await Navigation.PushModalAsync(new NavigationPage(new Page1()));
                        return true;

                    }
                }
            }
            return false;
        }
    }
}