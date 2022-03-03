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
    public partial class ReviewsFormPage : ContentPage
    {
        int count = 0;
        public ReviewsFormPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Clear()
        {
            star1.TextColor = Color.Gray;
            star2.TextColor = Color.Gray;
            star3.TextColor = Color.Gray;
            star4.TextColor = Color.Gray;
            star5.TextColor = Color.Gray;

        }

        private void star1_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            count = 1;
        }

        private void star2_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;
            count = 2;
        }

        private void star3_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;
            star3.TextColor = Color.Yellow;
            count = 3;
        }

        private void star4_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;
            star3.TextColor = Color.Yellow;
            star4.TextColor = Color.Yellow;
            count = 4;
        }

        private void star5_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;
            star3.TextColor = Color.Yellow;
            star4.TextColor = Color.Yellow;
            star5.TextColor = Color.Yellow;
            count = 5;
        }

        private async void SendBtn_Clicked(object sender, EventArgs e)
        {
            Review review = new Review($"{App.client.Surname} {App.client.Name} {App.client.Patronymic}", App.client.AvatarPath, ReviewEntry.Text, count);
            App.Db.SaveReview(review);
            await Navigation.PopAsync();
        }
    }
}