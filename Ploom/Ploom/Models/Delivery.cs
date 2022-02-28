using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("delivery")]
    class Delivery
    {
        public Delivery()
        {
        }

        public Delivery(string deliveryDate, string expectedDeliveryDate, Order order, List<Courier> courier)
        {
            DeliveryDate = deliveryDate;
            ExpectedDeliveryDate = expectedDeliveryDate;
            Order = order;
            Courier = courier;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }
        public string DeliveryDate { get; set; }
        public string ExpectedDeliveryDate { get; set; }
        [Unique]
        public Order Order { get; set; }
        public List<Courier> Courier { get; set; }

    }
}
