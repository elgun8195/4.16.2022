using ikinci_task_praktika.Models;
using System;

namespace ikinci_task_praktika
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string username;
            string section;
            string password;
            

            Console.WriteLine("Is the superadmin?");
            bool isSuperAdmin = Convert.ToBoolean(Console.ReadLine());

            do
            {
                Console.WriteLine("Username'i qeyd edin;");
                username = Convert.ToString(Console.ReadLine());


            } while (username.Length<=6);

            do
            {
                Console.WriteLine("Password'u qeyd edin:");
                password = Convert.ToString(Console.ReadLine());

            } while (!PassChecker(password));

            Console.WriteLine("Sectionu nedir:");
            section = Convert.ToString(Console.ReadLine());
            Admin admin = new Admin(isSuperAdmin,username,password,section);
            admin.ShowInfo();
        }


        public static bool PassChecker(string password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            if (string.IsNullOrWhiteSpace(password) == false )
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                        hasDigit = true;


                    if (char.IsUpper(item))
                        hasUpper = true;

                    if (hasDigit && hasUpper )
                        return true;
                }
            }
            return false;
        }
        
    }
}
