using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("courier")]
    class Courier
    {
        public Courier()
        {
        }

        public Courier(string surname, string name, string patronymic, string telephone, Delivery delivery)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Telephone = telephone;
            Delivery = delivery;
        }

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }
        public string Patronymic { get; set; }

        public string Telephone { get; set; }
        [Unique]
        public Delivery Delivery { get; set; }
    }
}
