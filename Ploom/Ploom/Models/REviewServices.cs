using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace Ploom.Models
{
    public class REviewSevices
    {
        public REviewSevices()
        {
        }

        public REviewSevices(string fIO, string path, string reviewText, Color star1, Color star2, Color star3, Color star4, Color star5)
        {
            FIO = fIO;
            Path = path;
            ReviewText = reviewText;
            //Count = count;
            Star1 = star1;
            Star2 = star2;
            Star3 = star3;
            Star4 = star4;
            Star5 = star5;
        }

        public int Id { get; set; }
        public string FIO { get; set; }
        public string Path { get; set; }
        public string ReviewText { get; set; }
        public Color Star1 { get; set; }
        public Color Star2 { get; set; }
        public Color Star3 { get; set; }
        public Color Star4 { get; set; }
        public Color Star5 { get; set; }

    }
}
