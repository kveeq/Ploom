using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    class Delivery
    {
        public int Id { get; set; }
        public string DeliveryDate { get; set; }
        public string ExpectedDeliveryDate { get; set; }
        public Order Order { get; set; }
        public List<Courier> Courier { get; set; }

    }
}
