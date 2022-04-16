using System;
using System.Collections.Generic;
using System.Text;

namespace ikinci_task_praktika.Models
{
    class Admin:User
    {
        public bool IsSuperAdmin { get; set; }
        public string Section { get; set; }
        public Admin(bool isSuperAdmin,string username,string password,string section)
        {
            IsSuperAdmin = isSuperAdmin;
            Username = username;
            Password = password;
            Section = section;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Username: {Username} - Password: {Password} - SuperAdmin: {IsSuperAdmin} - Section: {Section}");
        }
    }
}
