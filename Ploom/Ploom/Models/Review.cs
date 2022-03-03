using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("Review")]
    public class Review
    {
        public Review()
        {
        }

        public Review(string fIO, string path, string reviewText, int count/*, Color star1, Color star2, Color star3, Color star4, Color star5*/)
        {
            FIO = fIO;
            Path = path;
            ReviewText = reviewText;
            Count = count;
        }

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Path { get; set; }
        public string ReviewText { get; set; }
        public int Count { get; set; }

    }
}
