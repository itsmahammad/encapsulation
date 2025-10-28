using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class User
    {
        private int _Id;
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        private static int _Counter = 0;
        public int Id
        {
            get { return _Id; }
        }

        public User(int id, string fullname, string email, string password, int age)
        {
            _Id = id;
            Fullname = fullname;
            Email = email;
            Password = password;
            Age = age;
            _Counter++;
            id = _Counter;
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {_Id}, Fullname: {Fullname}, Email: {Email}");
        }

    }
}
