using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploom.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent(); FirnitureService.All();
            GoodsFilterLstView.ItemsSource = FirnitureService.lst;
            //GoodsLstViw2.ItemsSource = FirnitureService.lst;
        }

        private void HomeBtn_Tapped(object sender, EventArgs e)
        {

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
            string result = await DisplayActionSheet("Выберите материал:", null, null, "Искусственная кожа", "Искусственный мех", "Дерево", "Керамика");

            switch(result)
            {
                case "Искусственная кожа":
                    
                    break;

                case "Искусственный мех":
                    break;

                case "Дерево":
                    break;

                case "Керамика":
                    break;

            }
        }

        private void ColorBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ColorBoxVw.IsVisible = true;
        }

        private async void ProductBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ProductBoxVw.IsVisible = true;

            string result = await DisplayActionSheet("Выберите тип товара:", null, null, "Стулья", "Столы", "Комоды", "Шкафы");

            switch (result)
            {
                case "Стулья":

                    break;

                case "Столы":
                    break;

                case "Комоды":
                    break;

                case "Шкафы":
                    break;

            }
        }

        private async void PriceBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            PriceBoxVw.IsVisible = true;

            string result = await DisplayActionSheet("Ценовой диапазон:", null, null, "До 3000 р", "От 3000 до 7000 р", "От 7000 до 10 000 р");

            switch (result)
            {
                case "До 3000 р":

                    break;

                case "От 3000 до 7000 р":
                    break;

                case "От 7000 до 10 000 р":
                    break;

            }
        }
    }
}