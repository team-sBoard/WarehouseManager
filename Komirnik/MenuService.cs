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
                Console.WriteLine("Please, enter the menu №");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        KomirnikOrderManagement();
                        break;
                    case "2":
                        KomirnikProductManagement();
                        break;
                    case "3":
                        //KomirnikProductDisplay();
                        break;
                    case "4":                       
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Invalid selected " + command + " item of menu. Please, select the proper part");
                        break;
                }
            } while (command != "4");
            Console.WriteLine("Cya later!");
        }

            public static void KomirnikOrderManagement()
            {
                string command;

                do
                {
                    Console.WriteLine(Menu.KomirnikOrderManagementMenu());
                    Console.WriteLine("Please, enter the menu №");
                    command = Console.ReadLine();

                    switch (command)
                    {
                        case "1":
                            CreateShippingOrder();
                            break;
                        case "2":
                            CreateRecievingOrder();
                            break;
                        case "3":
                            break;

                        default:
                            Console.WriteLine("Invalid selected " + command + " item of menu. Please, select the proper part");
                            break;
                    }
                } while (command != "3");
                Console.WriteLine("Returning back");
            }

            private static void CreateRecievingOrder()
            {
                Console.WriteLine("You have issued a Receiving order");
            }

            private static void CreateShippingOrder()
        {
            Console.WriteLine("You have issued a Shipping Order");
        }
        public void KomirnikProductManagement()
        {
            string command;

            do
            {
                Console.WriteLine(Menu.KomirnikProductManagementMenu());
                Console.WriteLine("Please, enter the menu №");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        CreateProduct();
                        break;
                    case "2":
                        UpdateProduct();
                        break;
                    case "3":
                        DeleteProduct();
                        break;
                    case "4":
                        break;                       
                    default:
                        Console.WriteLine("Invalid selected " + command + " item of menu. Please, select the proper part");
                        break;
                }
            } while (command != "4");
            Console.WriteLine("Returning back");
        }

        private static void DeleteProduct()
        {
            Console.WriteLine("You have deleted banana");
        }

        private static void UpdateProduct()
        {
            Console.WriteLine("You have updated banana");
        }

        private static void CreateProduct()
        {
            Console.WriteLine("You have created banana");
        }                  

        //private static void KomirnikProductDisplay()
        //{
        //    string command;
        //    do
        //    {
        //        Console.WriteLine(Menu.KomirnikProductDisplayMenu());
        //        Console.WriteLine("Please, enter the menu №");
        //        command = Console.ReadLine();

        //        switch (command)
        //        {
        //            case "1":
        //                DisplayByName();
        //                break;
        //            case "2":
        //                DisplayByOrigin();
        //                break;
        //            case "3":
        //                DisplayByCategory();
        //                break;
        //            case "4":
        //                DisplayAllCountries();
        //                break;
        //            case "5":
        //                DisplayProductForCountry();
        //                break;
        //            case "6":
        //                DisplayEverything();
        //                break;
        //            case "7":
        //                break;
        //            default:
        //                Console.WriteLine("Invalid selected " + command + " item of menu. Please, select the proper part");
        //                break;
        //        }
        //    } while (command != "7");
        //    Console.WriteLine("Returning back");
        //}


        //public static void DisplayByName()
        //{
        //    Console.WriteLine("Here the full list of goods sorted by their Name :");
        //    Console.WriteLine("Product Name: Country of Origin, Quantity");

        //    foreach (Product product in )
        //    {
        //        Console.WriteLine(string.Format(
        //                "{1} {2} {3}",
        //                product.name,
        //                product.origin,
        //                product.quantity));
        //    }
        //}
        //public static void DisplayByOrigin()
        //{
        //    Console.WriteLine("Here the full list of goods sorted by Country of Origin :");
        //    Console.WriteLine("Product Name: Country of Origin, Quantity");

        //    foreach (Product product in )
        //    {
        //        Console.WriteLine(string.Format(
        //                "{1} {2} {3} {4}",
        //                product.name,
        //                product.origin,
        //                product.quantity));
        //    }
        //}
        //public static void DisplayByCategory()
        //{
        //    Console.WriteLine("Here the full list of goods sorted by Category :");
        //    Console.WriteLine("Category, Product Name, Quantity");

        //    foreach (Product product in )
        //    {
        //        Console.WriteLine(string.Format(
        //                "{1} {2} {3} {4}",
        //                product.name,
        //                product.type,
        //                product.quantity));
        //    }
        //}
        //public static void DisplayAllCountries()
        //{
        //    Console.WriteLine("Here the full list of Countries-manufacturers:");
        //    Console.WriteLine("Country name: ");

        //    foreach (Product product in )
        //    {
        //        Console.WriteLine(string.Format(
        //                "{1}",
        //                product.origin));
        //    }
        //}
        //public static void DisplayProductForCountry()
        //{
        //    Console.WriteLine("Here the the product list for:" + "Тут нужно вставлять ту страну, которую введёт пользователь"); //Подумать над методом решения

        //    foreach (Product product in )
        //    {
        //        Console.WriteLine(string.Format(
        //                "{1} {2}",
        //                product.origin,
        //                product.type));
        //    }
        //}
        //public static void DisplayEverything()
        //{
        //    Console.WriteLine("Here the full list of goods:");
        //    Console.WriteLine("Product Name: Country of Origin, Quantity, Category");

        //    foreach (Product product in )
        //    {
        //        Console.WriteLine(string.Format(
        //                "{1} {2} {3} {4}",
        //                product.name,
        //                product.origin,
        //                product.quantity,
        //                product.type));
        //    }
        //}

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
