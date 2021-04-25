using System;

namespace Komirnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Authorization();
        }

        public static void Authorization()
        {
            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if (login != "admin" && password != "123")
            {
                
            }
        }
    }
}