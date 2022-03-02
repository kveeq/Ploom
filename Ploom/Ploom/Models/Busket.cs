using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    [Table("busket")]
    public class Busket
    {
        public Busket()
        {

        }

        public Busket(int quantity, int clientId, int furnitureId)
        {
            Quantity = quantity;
            ClientId = clientId;
            FurnitureId = furnitureId;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int ClientId { get; set; }
        public int FurnitureId { get; set; }
    }
}
