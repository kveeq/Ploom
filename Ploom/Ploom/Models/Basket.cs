using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("basket")]
    public class Basket
    {
        public Basket()
        {
        }

        public Basket(int quantity, Client clientId, Furniture furnitureId)
        {
            Quantity = quantity;
            ClientId = clientId;
            FurnitureId = furnitureId;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public Client ClientId { get; set; }
        public Furniture FurnitureId { get; set; }
    }
}
