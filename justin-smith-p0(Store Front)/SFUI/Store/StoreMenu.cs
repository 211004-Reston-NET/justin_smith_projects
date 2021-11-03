using System;

namespace SFUI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Store Menu!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - View Stores");
            Console.WriteLine("[2] - View All Products");
            Console.WriteLine("[3] - View Store Inventory");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.ShowStore;
                case "2":
                    return MenuType.ProductMenu;
                case "3":
                    return MenuType.ShowInventory;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreMenu;
            }
        }
    }
}