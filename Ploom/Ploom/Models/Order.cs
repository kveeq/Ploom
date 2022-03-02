using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("order")]
    class Order
    {
        public Order()
        {
        }

        public Order(int amount, string date, int basketId)
        {
            Amount = amount;
            Date = date;
            BasketId = basketId;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
        public int BasketId { get; set; }
    }
}
