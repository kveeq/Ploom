using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    public class Client
    {

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        public string TelephoneNumber { get; set; }

        public string EMail { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}
