using System;

namespace SFUI
{
    public class CustomerMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Customer Menu!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - List of Customers");
            Console.WriteLine("[2] - Add a Customer");
            Console.WriteLine("[3] - View Customer Orders");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.ShowCustomer;
                case "2":
                    return MenuType.AddCustomer;
                case "3":
                    return MenuType.CustomerOrder;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CustomerMenu;
            }
        }
    }
}