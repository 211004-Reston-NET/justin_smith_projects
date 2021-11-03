using System;
using SFBL;
using SFDL;

namespace SFUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            object obj = x;

            bool repeat = true;

            IFactory factory = new MenuFactory();

            IMenu page = factory.GetMenu(MenuType.MainMenu);
            while (repeat)
            {
                Console.Clear();
                page.Menu();
                MenuType currentPage = page.YourChoice();

                if (currentPage == MenuType.Exit)
                {
                    Console.WriteLine("Exiting the Application. Press enter to continue.");
                    Console.ReadLine();
                    repeat = false; 
                }
                else
                {
                    page = factory.GetMenu(currentPage);
                }
                    
                
            }
        }
    }
}












// switch (currentPage)
//                 {
//                     case MenuType.MainMenu:
//                         page = new MainMenu();
//                         break;
//                     // case MenuType.ShowCustomers:
//                     //     page = new ShowCustomer();
//                     //     break;
//                     case MenuType.ShowStore:
//                     page = new ShowStore(new StoreBL(new Respository()));
//                     break;
//                     case MenuType.StoreMenu:
//                         page = new StoreMenu();
//                         break;
//                     // case MenuType.PlaceOrder:
//                     //     page = new PlaceOrder();
//                     //     break;
//                     case MenuType.ViewOrder:
//                         page = new ViewOrder();
//                         break;
//                     case MenuType.Exit:
//                         Console.WriteLine("You are exiting the application!");
//                         Console.WriteLine("Press Enter to continue");
//                         Console.ReadLine();
//                         repeat = false;
//                         break;
//                     default: 
//                         Console.WriteLine("You forgot to add a menu in your enum/code");
//                         repeat = false;
//                         break;