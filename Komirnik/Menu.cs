namespace Komirnik
{
    public static class Menu
    {
        public static string AdminMenu()
        {
            return "[Admin - Menu] - Komirnik \n" +
               " 1) Add komirnika \n" +
               " 2) Quit ";
        }
        public static string KomirnikMenu()
        {
            return "[Komirnik - Menu] - Komirnik \n" +
               " 1) Order management \n" +
               " 2) Product management \n" +
               " 3) Display product list \n" +
               " 4) Quit";
        }
        public static string KomirnikOrderManagementMenu()
        {
            return "[Komirnik - Menu] - Komirnik - Order management \n" +
               " 1.1) Issue shipping order \n" +
               " 1.2) Issue recieving order  \n" +
               " 1.3) Back ";
        }
        public static string KomirnikProductManagement()
        {
            return "[Komirnik - Menu] - Komirnik - Add product \n" +
               " 2.1) Create product \n" +
               " 2.2) Update product  \n" +
               " 2.3) Delete product \n " +
               " 2.4) Back ";
        }
    }
}
