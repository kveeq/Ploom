using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    class Order
    {
        public Order()
        {
        }

        public Order(int amount, string date, Basket basketId)
        {
            Amount = amount;
            Date = date;
            BasketId = basketId;
        }

        public int Id { get; set; }

        public int Amount { get; set; }

        public string Date { get; set; }

        public Basket BasketId { get; set; }
    }
}
