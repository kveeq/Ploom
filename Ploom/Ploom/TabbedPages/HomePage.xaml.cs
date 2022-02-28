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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //FirnitureService.All();
            GoodsLstViw.ItemsSource = App.Db.GetFurnituress();
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
    }
}