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
            //FirnitureService.All();
            //BusketLst.ItemsSource = FirnitureService.lst;
            BusketLst.RefreshCommand = new Command(() =>
            {
                BusketLst.IsRefreshing = false; //выключить анимацию обновления 
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            UpdateList();
        }
        void UpdateList()
        {
            //imgList.ItemsSource = Directory.GetFiles(folderPath).Select(f => Path.GetFullPath(f));
            BusketLst.ItemsSource = null;
            List<Furniture> aa = new List<Furniture>();
            var a = App.Db.GetBasket();
            int price = 0;
            //var aff = App.Db.GetBasket().Select(f => f).Where(x => x.ClientId == App.client.Id);
            foreach (var item in a)
            {
                if (App.client.Id == item.ClientId)
                {
                    aa.Add(App.Db.GetProjectItem(item.FurnitureId));
                    price += int.Parse(App.Db.GetProjectItem(item.FurnitureId).Price);
                }
            }
            BusketLst.ItemsSource = aa;
            GoodAmountLbl.Text = $"Товара ({aa.Count}):";
            GoodPriceLbl.Text = $"{price} P";
        }

        private void SwipeItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                var id = ((SwipeItem)sender).CommandParameter.ToString();
                var fre = App.Db.GetBasket();

                foreach (var item in fre)
                {
                    if (item.FurnitureId == int.Parse(id))
                    {
                        App.Db.DeleteFurnitureInBusket(item.Id);
                        break;
                    }
                }
                UpdateList();
            }
            catch (Exception ex)
            {
                DisplayAlert("", ex.Message, "ok");
            }
        }

        private async void OrderBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckoutPage());
        }
    }
}