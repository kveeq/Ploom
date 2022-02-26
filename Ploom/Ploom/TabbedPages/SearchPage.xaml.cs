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

        private void MaterialBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            MaterialBoxVw.IsVisible = true;
        }

        private void ColorBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ColorBoxVw.IsVisible = true;
        }

        private void ProductBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            ProductBoxVw.IsVisible = true;
        }

        private void PriceBtn_Clicked(object sender, EventArgs e)
        {
            CleanAllBtnBoxViews();
            PriceBoxVw.IsVisible = true;
        }
    }
}