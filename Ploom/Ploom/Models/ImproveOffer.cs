using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("ImproveOffer")]
    public class ImproveOffer
    {
        public ImproveOffer()
        {
        }

        public ImproveOffer(int clientId, string review)
        {
            ClientId = clientId;
            Review = review;
        }

        public ImproveOffer(string review)
        {
            Review = review;
        }

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Review { get; set; }
    }
}
