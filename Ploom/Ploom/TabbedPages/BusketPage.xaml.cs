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
    public partial class BusketPage : ContentPage
    {
        public BusketPage()
        {
            InitializeComponent();
            FirnitureService.All();
            BusketLst.ItemsSource = FirnitureService.lst;
        }
    }
}