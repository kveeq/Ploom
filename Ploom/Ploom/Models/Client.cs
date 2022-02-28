using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ploom.Models
{
    [Table("clients")]
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

        [AutoIncrement, PrimaryKey, Column("_id")]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        public string TelephoneNumber { get; set; }

        public string EMail { get; set; }

        [Unique]
        public string Login { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}
