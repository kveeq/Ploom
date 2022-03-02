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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //FirnitureService.All();
            Update();
            GoodsLstViw.RefreshCommand = new Command(() =>
            {
                Update();
                GoodsLstViw.IsRefreshing = false; //выключить анимацию обновления 

            });
        }

        private void Update()
        {
            GoodsLstViw.ItemsSource = null;

            if (ChairBoxVw.IsVisible)
                GoodsLstViw.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[0]);
            else if (TableBoxVw.IsVisible)
                GoodsLstViw.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[1]);
            else if (ComodBoxVw.IsVisible)
                GoodsLstViw.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[2]);
            else if (CupboardBoxVw.IsVisible)
                GoodsLstViw.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[3]);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (App.client.RoleId == 0)
                AdminPanel.IsVisible = false;
            else if (App.client.RoleId == 1)
                AdminPanel.IsVisible = true;
        }

        private void ChairBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ChairBoxVw.IsVisible = true;
            Update();
        }

        private void TableBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            TableBoxVw.IsVisible = true;
            Update();
        }

        private void ComodBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ComodBoxVw.IsVisible = true;
            Update();
        }

        private void cupboard_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            CupboardBoxVw.IsVisible = true;
            Update();
        }

        private void CleanAllBtnBoxViews()
        {
            ChairBoxVw.IsVisible = false;
            TableBoxVw.IsVisible = false;
            ComodBoxVw.IsVisible = false;
            CupboardBoxVw.IsVisible = false;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddFurniturePage());
        }

        private async void GoodsLstViw_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var d = (Furniture)e.Item;
            var a = new MoreInfoAboutFurniturePage(d);
            a.BindingContext = d;
            await Navigation.PushAsync(a);
        }
    }
}