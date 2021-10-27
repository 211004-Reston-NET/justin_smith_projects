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
            Console.WriteLine("[2] - Customer Lookup");
            Console.WriteLine("[3] - Return to Main Menu");

        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            
            switch (userChoice)
            {
                case "1":
                    return MenuType.StoreMenu;
                case "2":
                    return MenuType.CustomerMenu;
                case "3":
                    return MenuType.MainMenu;
                case "4":
                    return MenuType.ShowStore;
                       
                default:
                     Console.WriteLine("Invalid Response!");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    return MenuType.StoreMenu;
            }
        }
    }
}