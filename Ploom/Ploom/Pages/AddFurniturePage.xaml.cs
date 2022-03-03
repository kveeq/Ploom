using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Ploom.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ploom.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFurniturePage : ContentPage
    {
        string path;
        bool state;
        bool state1 = false;
        Furniture furniture;
        public AddFurniturePage()
        {
            InitializeComponent();
            BarLbl.Text = "Добавление мебели";
            TypeFurniture.ItemsSource = App.types;
            ColorFurniture.ItemsSource = App.colors;
            MaterialFurniture.ItemsSource = App.materials;
            state = true;
        }
        public AddFurniturePage(Furniture fur)
        {
            furniture = fur;
            InitializeComponent();
            TypeFurniture.ItemsSource = App.types;
            ColorFurniture.ItemsSource = App.colors;
            MaterialFurniture.ItemsSource = App.materials;
            NameFurniture.Text = furniture.Name;
            DescriptionFurniture.Text = furniture.Description;
            PriceFurniture.Text = furniture.Price;
            TypeFurniture.SelectedItem = furniture.Type;
            ColorFurniture.SelectedItem = furniture.Color;
            MaterialFurniture.SelectedItem = furniture.Material;
            BarLbl.Text = "Редактирование";
            state = false;
        }

        private async void RegistrateBtn_Clicked(object sender, EventArgs e)
        {

            string result = await DisplayActionSheet("Выберите:", null, null, "Фото из галереи", "Фото из камеры");

            if (result == "Фото из галереи")
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
                    state1 = true;
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
                }
            }
            else
            {
                try
                {
                    var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
                    {
                        Title = $"xamarin.{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.png"
                    });

                    // для примера сохраняем файл в локальном хранилище
                    var newFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), photo.FileName);
                    using (var stream = await photo.OpenReadAsync())
                    using (var newStream = File.OpenWrite(newFile))
                    {
                        await stream.CopyToAsync(newStream);
                    }

                    //Debug.WriteLine($"Путь фото {photo.FullPath}");
                    // загружаем в ImageView
                    path = photo.FullPath;
                    state1 = true;
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
                }

            }
        }

        private async void SaveBtn_Clicked(object sender, EventArgs e)
        {
            if (state)
                App.Db.SaveFurniture(new Furniture(NameFurniture.Text, DescriptionFurniture.Text, PriceFurniture.Text, ColorFurniture.SelectedItem.ToString(), TypeFurniture.SelectedItem.ToString(), MaterialFurniture.SelectedItem.ToString(), path));
            else
            {
                if (state1)
                    furniture.ImagePath = path;
                furniture.Type = TypeFurniture.SelectedItem.ToString();
                furniture.Color = ColorFurniture.SelectedItem.ToString();
                furniture.Material = MaterialFurniture.SelectedItem.ToString();
                App.Db.SaveFurniture(furniture);
            }
            await Navigation.PopAsync();
        }

        private async void BackLbl_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}