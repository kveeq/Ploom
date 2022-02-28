using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
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

        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }
        public string Patronymic { get; set; }

        public string Telephone { get; set; }

        public Delivery Delivery { get; set; }
    }
}
