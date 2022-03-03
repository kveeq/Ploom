using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploom.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewsPage : ContentPage
    {
        public ReviewsPage()
        {
            InitializeComponent();
            Update();
            ReviewsLst.RefreshCommand = new Command(() =>
            {
                Update();
                ReviewsLst.IsRefreshing = false; //выключить анимацию обновления 
            });
        }

        private void Update()
        {
            ReviewsLst.ItemsSource = null;
            List<REviewSevices> res = new List<REviewSevices>();
            foreach (var item in App.Db.GetReviews())
            {

                Color color1 = Color.Gray;
                Color color2 = Color.Gray;
                Color color3 = Color.Gray;
                Color color4 = Color.Gray;
                Color color5 = Color.Gray;

                switch (item.Count)
                {
                    case 1:
                        color1 = Color.Yellow;
                        break;
                    case 2:
                        color1 = Color.Yellow;
                        color2 = Color.Yellow;
                        break;
                    case 3:
                        color1 = Color.Yellow;
                        color2 = Color.Yellow;
                        color3 = Color.Yellow;
                        break;
                    case 4:
                        color1 = Color.Yellow;
                        color2 = Color.Yellow;
                        color3 = Color.Yellow;
                        color4 = Color.Yellow;
                        break;
                    case 5:
                        color1 = Color.Yellow;
                        color2 = Color.Yellow;
                        color3 = Color.Yellow;
                        color4 = Color.Yellow;
                        color5 = Color.Yellow;
                        break;
                }
                res.Add(new REviewSevices(item.FIO, item.Path, item.ReviewText, color1, color2, color3, color4, color5));
            }
            ReviewsLst.ItemsSource = res;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewsFormPage());
        }
    }
}