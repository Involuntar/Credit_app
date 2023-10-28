using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data
{
    class Users
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Users(string firstname, string middlename, string lastname, string login, string password, string email)
        {
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            Login = login;
            Password = password;
            Email = email;
        }
    }
}
