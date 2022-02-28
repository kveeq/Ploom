using System;
using System.Collections.Generic;
using System.Text;

namespace Ploom.Models
{
    public class Client
    {
        public Client()
        {
        }

        public Client(string surname, string name, string patronymic, string telephoneNumber, string eMail, string login, string password, int roleId)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            TelephoneNumber = telephoneNumber;
            EMail = eMail;
            Login = login;
            Password = password;
            RoleId = roleId;
        }

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
