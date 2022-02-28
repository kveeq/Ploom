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
    public partial class ReviewsPage : ContentPage
    {
        public ReviewsPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}