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

        public Furniture(string name, string description, string price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public string _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
