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


            do
            {
                Console.WriteLine();
                bool isSuperAdmin = Convert.ToBoolean(Console.ReadLine());

            } while (!HasUpper());

            Admin admin = new Admin(true,username,section);
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
