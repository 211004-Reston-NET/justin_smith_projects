using System;

namespace SFUI
{
    public class CustomerMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Customer Menu!");
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
                default:
                    Console.WriteLine("Invalid Response!");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    return MenuType.CustomerMenu;
            }
        }
    }
}