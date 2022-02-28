using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilPage : ContentPage
    {
        public ProfilPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewsPage());
        }
    }
}