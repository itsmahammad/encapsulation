using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class User
    {
        private int _id;
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public int Age { get; set; }

        private static int _counter = 0;
        public int Id
        {
            get { return _id; }
        }

        public string Password {
            get { return _password; }
            set
            {
                if (PasswordChecker(value)==true) _password = value;
                else Console.WriteLine("invalid password");
            }
        }
        

        public User(string fullname, string email, string password, int age)
        {
            _counter++;
            _id = _counter;
            Fullname = fullname;
            Email = email;
            Password = password;
            Age = age;
            
        }


        public static bool PasswordChecker(string password)
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
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}, Age: {Age}");
        }

    }
}
