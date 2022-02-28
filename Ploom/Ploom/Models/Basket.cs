using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    public class Basket
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public Client ClientId { get; set; }
        public Furniture FurnitureId { get; set; }
    }
}
