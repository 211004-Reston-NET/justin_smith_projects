using System;

namespace SFUI
{
    class ViewOrder : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[4] - View Customers");
            Console.WriteLine("[3] - View Stores");
            Console.WriteLine("[2] - View Orders");
            Console.WriteLine("[1] - View Products");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "4":
                    return MenuType.CustomerMenu;
                case "3":
                    return MenuType.StoreMenu;
                case "2":
                    return MenuType.OrderMenu;
                case "1":
                    return MenuType.ProductMenu;
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
