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
                string[] aa = new string[3];
                bool state = false;
                try
                {
                    aa = FIOEntry.Text.Split();
                    state = true;
                }
                catch
                {
                    throw new Exception("Введите корректное ФИО");
                }
                if (state)
                {
                    if ((TelNumberEntry.Text == null || TelNumberEntry.Text == "") || (EmailEntry.Text == null || EmailEntry.Text == "") || (LoginEntry.Text == null || LoginEntry.Text == "") || (PassEntry.Text == null || PassEntry.Text == ""))
                        throw new Exception("Введите корректные данные");
                    else
                    {
                        Client client = new Client(aa[0], aa[1], aa[2], TelNumberEntry.Text, EmailEntry.Text, LoginEntry.Text, PassEntry.Text, 0);
                        App.Db.SaveClient(client);
                        App.client = client;
                        await Navigation.PushModalAsync(new NavigationPage(new Page1()));
                    }

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Не удалось зарегистрироваться " + ex.Message, "Ok");
            }
        }
    }
}