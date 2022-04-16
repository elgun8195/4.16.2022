using System;
using System.Collections.Generic;
using System.Text;

namespace ikinci_task_praktika.Models
{
    class User
    {
        private static string _username;
        private static string _password;
        public string Username
        {
            get { return _username; }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (HasDigit(value) && HasUpper(value) )
                {
                    _password = value;
                }
            }
        }


        public static bool HasDigit(string word)
        {
            if (char.IsDigit(Convert.ToChar(word)))
            {
                return true;
            }
            return false;
        }

        public static bool HasUpper(string word)
        {
            if (char.IsUpper(Convert.ToChar(word)))
            {
                return true;
            }
            return false;
        }
    }

}

