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
        public string Password { get;set; }

        //public string Password
        //{
        //    get { return _password; }
        //    set
        //    {
        //        if (HasDigit(value) && HasUpper(value) )
        //        {
        //            _password = value;
        //        }
        //    }
        //}


        //public static bool HasDigit(string word)
        //{
        //    if (char.IsDigit(Convert.ToChar(word)))
        //    {
        //        return true;
        //    }
        //    return false;
        //}



        //public static bool HasUpper(string word)
        //{
        //    if (char.IsUpper(Convert.ToChar(word)))
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        public static bool PasswordChecker(string password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            if (string.IsNullOrWhiteSpace(password) == false)
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                        hasDigit = true;


                    if (char.IsUpper(item))
                        hasUpper = true;

                    if (hasDigit && hasUpper)
                        return true;
                }
            }

            return false;
        }

    }

}

