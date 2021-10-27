using System;

namespace SFUI
{
    public class MainMenu : IMenu
    {   
        bool repeat = true;
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("[1] - Store Locations");
            Console.WriteLine("[2] - Customer Lookup");
            Console.WriteLine("[3] - Exit Application");
            Console.WriteLine("[4] - Show Store Locations");
 
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
                    return MenuType.ExitMenu;
                case "4":
                    return MenuType.ShowStore;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
                    
                
            }
        }
    }
}