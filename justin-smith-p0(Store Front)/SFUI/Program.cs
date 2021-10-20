using System;
using SFBL;
using SFDL;

namespace SFUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            IMenu page = new MainMenu();
            while (repeat)
            {
                Console.Clear();
                page.Menu();
                MenuType currentPage = page.YourChoice();

                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuType.AddCustomer:
                        page = new AddCustomer();
                        break;
                    case MenuType.SearchCustomer:
                        page = new SearchCustomer();
                        break;
                    case MenuType.StoreMenu:
                        page = new StoreMenu();
                        break;
                    case MenuType.PlaceOrder:
                        page = new PlaceOrder();
                        break;
                    case MenuType.ViewOrder:
                        page = new ViewOrder();
                        break;
                    case MenuType.Exit:
                        Console.WriteLine("You are exiting the application!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default: 
                        Console.WriteLine("You forgot to add a menu in your enum/code");
                        repeat = false;
                        break;


                }
            }
        }
    }
}
