using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    class Courier
    {
        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }
        public string Patronymic { get; set; }

        public string Telephone { get; set; }

        public Delivery Delivery { get; set; }
    }
}
