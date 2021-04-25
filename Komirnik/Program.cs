using System;
using System.Collections.Generic;

namespace Komirnik
{
    class Program
    {
        

        static void Main(string[] args)
        {
            MenuService menuService = new MenuService();

            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            //Надо запихнуть нового юзера в Users.List и дать ему возможность клацать своё меню (не админа)

            User user = new User(login, password);

            if (login != "admin" && password != "123")
            {
                menuService.Komirnik();
            }
            else
            {
                menuService.Admin();
            }
        }

    }
}