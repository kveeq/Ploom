using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploom.TabbedPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckoutPage : ContentPage
    {
        public CheckoutPage(int a, int b)
        {
            InitializeComponent();
            AmountLbl.Text = $"Товары ({a}):";
            SumLbl.Text = $"{b} P";
            SumLbl1.Text = $"{b} P";
            FIOEntry.Text = $"{App.client.Surname} {App.client.Name} {App.client.Patronymic}";
            BindingContext = App.client;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OrderBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Уведомление", "Заказ успешно оформлен", "ОК");
            await Navigation.PopAsync();
        }
    }
}