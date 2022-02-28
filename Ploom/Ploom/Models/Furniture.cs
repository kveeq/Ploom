using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("furniture")]
    public class Furniture
    {
        public Furniture()
        {
        }

        public Furniture(string name, string description, string price, string color, string type, string material, string imagePath)
        {
            Name = name;
            Description = description;
            Price = price;
            Color = color;
            Type = type;
            Material = material;
            ImagePath = imagePath;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public string ImagePath { get; set; }
    }
}
