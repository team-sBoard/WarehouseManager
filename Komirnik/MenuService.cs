using System;
using System.Collections.Generic;

namespace Komirnik
{
    public class MenuService
    {
        public void Admin()
        {
            string command;

            do
            {
                Console.WriteLine(Menu.AdminMenu());
                Console.WriteLine("Please, type menu №");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        AddKomirnik();
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Invalid selected " + command + " item of menu. Please, select the proper part");
                        break;
                }
            } while (command != "2");
            Console.WriteLine("Cya later!");
        }

        public void Komirnik()
        {
            string command;

            do
            {
                Console.WriteLine(Menu.KomirnikMenu());
                Console.WriteLine("Please, type menu №");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Menu.KomirnikOrderManagementMenu();
                        break;
                    case "2":
                        Menu.KomirnikProductManagement();
                        break;
                    case "3":
                        MenuService.DisplayProductList();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid selected " + command + " item of menu. Please, select the proper part");
                        break;
                }
            } while (command != "4");
            Console.WriteLine("Cya later!");
        }

        public static void DisplayProductList()
        {
                Console.WriteLine("Students:");
                Console.WriteLine("Id: FirstName LastName");

                foreach (Product product in )
                {
                Console.WriteLine(string.Format(
                        "{1} {2} {3} {4}",
                        product.name,
                        product.origin,
                        product.quantity,
                        product.type));
                }
        }

        public void AddKomirnik()
        {
            Console.WriteLine("Enter new login: ");
            
            string login = Console.ReadLine();
            Console.WriteLine("Enter new password: ");
            
            string password = Console.ReadLine();
            
            User user = new User(login, password);
            
            
            List<User> users = new List<User>();
            users.Add(user);
        }
    }
}
