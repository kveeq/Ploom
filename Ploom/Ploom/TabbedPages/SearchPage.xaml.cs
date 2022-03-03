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
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            Update();
            GoodsFilterLstView.RefreshCommand = new Command(() =>
            {
                Update();
                GoodsFilterLstView.IsRefreshing = false; //выключить анимацию обновления 
            });
            //GoodsLstViw2.ItemsSource = FirnitureService.lst;
        }

        private void Update()
        {
            GoodsFilterLstView.ItemsSource = null;
            GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress();
        }

        private void CleanAllBtnBoxViews()
        {
            MaterialBoxVw.IsVisible = false;
            ColorBoxVw.IsVisible = false;
            ProductBoxVw.IsVisible = false;
            PriceBoxVw.IsVisible = false;
        }

        private async void MaterialBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            MaterialBoxVw.IsVisible = true;
            string result = await DisplayActionSheet("Выберите материал:", null, null, App.materials);

            switch (result)
            {
                case "Искусственная кожа":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Material == App.materials[0]);
                    break;

                case "Искусственный мех":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Material == App.materials[1]);
                    break;

                case "Дерево":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Material == App.materials[2]);
                    break;

                case "Керамика":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Material == App.materials[3]);
                    break;

            }
        }

        private async void ColorBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ColorBoxVw.IsVisible = true;

            string result = await DisplayActionSheet("Выберите цвет:", null, null, App.colors);

            switch (result)
            {
                case "Белый":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Color == App.colors[0]);
                    break;

                case "Фиолетовый":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Color == App.colors[1]);
                    break;

                case "Желтый":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Color == App.colors[3]);
                    break;

                case "Красный":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Color == App.colors[2]);
                    break;

            }
        }

        private async void ProductBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ProductBoxVw.IsVisible = true;

            string result = await DisplayActionSheet("Выберите тип товара:", null, null, App.types);

            switch (result)
            {
                case "Стул":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[0]);
                    break;

                case "Стол":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[1]);
                    break;

                case "Комод":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[2]);
                    break;

                case "Шкаф":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Type == App.types[3]);
                    break;

            }
        }

        private async void PriceBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            PriceBoxVw.IsVisible = true;
            string[] aa = new string[3] { "До 3000 р", "От 3000 до 7000 р", "От 7000 до 10 000 р" };
            string result = await DisplayActionSheet("Ценовой диапазон:", null, null, aa);

            switch (result)
            {
                case "До 3000 р":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => int.Parse(x.Price) < 3000);
                    break;

                case "От 3000 до 7000 р":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => int.Parse(x.Price) >= 3000 && int.Parse(x.Price) < 7000);
                    break;

                case "От 7000 до 10 000 р":
                    GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => int.Parse(x.Price) >= 7000 && int.Parse(x.Price) < 10000);
                    break;

            }
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            GoodsFilterLstView.ItemsSource = App.Db.GetFurnituress().Select(f => f).Where(x => x.Name.Contains(searchBar.Text));
        }
    }
}