using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFurniturePage : ContentPage
    {
        string path;
        public AddFurniturePage()
        {
            InitializeComponent();
        }

        private async void RegistrateBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                // выбираем фото
                var photo = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = $"Xamarin.{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.png"
                });

                var newFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), photo.FileName);

                // загружаем в ImageView

                path = photo.FullPath;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        private async void SaveBtn_Clicked(object sender, EventArgs e)
        {
           App.Db.SaveFurniture(new Models.Furniture(NameFurniture.Text, DescriptionFurniture.Text, PriceFurniture.Text, ColorFurniture.Text, TypeFurniture.Text, MaterialFurniture.Text, path));
           await Navigation.PopAsync();
        }
    }
}