using System;
using System.Collections.Generic;
using System.Text;

namespace SecurePasswordDemo.Data
{
    public class User
    {
        private int _userId;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _password;
        private string _salt;

        public int UserId { get => _userId; set => _userId = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Salt { get => _salt; set => _salt = value; }

        public string GetFullName { get => $"{FirstName} {LastName}"; }
    }
}
