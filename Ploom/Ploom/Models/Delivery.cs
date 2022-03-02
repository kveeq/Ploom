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

        public Delivery(string deliveryDate, string expectedDeliveryDate, int order)
        {
            DeliveryDate = deliveryDate;
            ExpectedDeliveryDate = expectedDeliveryDate;
            Order = order;
            //CourierIds = courier;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }
        public string DeliveryDate { get; set; }
        public string ExpectedDeliveryDate { get; set; }
        [Unique]
        public int Order { get; set; }
        //public List<int> CourierIds { get; set; }

    }
}