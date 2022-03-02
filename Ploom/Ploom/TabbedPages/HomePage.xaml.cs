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
            GoodsLstViw.ItemsSource = App.Db.GetFurnituress();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (App.client.RoleId == 0)
                AdminPanel.IsVisible = false;
            else if (App.client.RoleId == 1)
                AdminPanel.IsVisible = true;
        }

        private void HomeBtn_Tapped(object sender, EventArgs e)
        {

        }

        private void ChairBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ChairBoxVw.IsVisible = true;
        }

        private void TableBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            TableBoxVw.IsVisible = true;
        }

        private void ComodBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ComodBoxVw.IsVisible = true;
        }

        private void cupboard_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            CupboardBoxVw.IsVisible = true;
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