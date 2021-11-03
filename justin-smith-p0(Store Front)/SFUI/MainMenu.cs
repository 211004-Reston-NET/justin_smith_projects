using System;

namespace SFUI
{
    class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - View Customers");
            Console.WriteLine("[2] - View Stores");
            Console.WriteLine("[3] - View All Products");
            Console.WriteLine("[0] - Exit");
        }

         public void ThisIsOnlyForMainMenuCFile()
        {
            throw new NotImplementedException();
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.CustomerMenu;
                case "2":
                    return MenuType.StoreMenu;
                case "3":
                    return MenuType.ShowProduct;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}
