using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    public class Furniture
    {
        public Furniture()
        {
        }

        public Furniture(string name, string description, string price, string color, string type, string material, string imagePath)
        {
            Color = color;
            Type = type;
            Material = material;
            ImagePath = imagePath;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }

        public string Material { get; set; }

        public string ImagePath { get; set; }
    }
}
