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
                MenuType selectMenu = page.YourChoice();
                

                switch (selectMenu)
                {
                    case MenuType.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuType.StoreMenu:
                        page = new StoreMenu();
                        break;
                    case MenuType.CustomerMenu:
                        page = new CustomerMenu();
                        break;
                    case MenuType.ShowStore:
                        page = new ShowStore(new StoreBL(new Repository()));
                        break;
                    case MenuType.ExitMenu:
                        repeat = false;
                        Console.WriteLine("You are exiting the application.  Press enter to continue.");
                        Console.ReadLine();
                    break;
                    default:
                        Console.WriteLine("You forgot an enum in your code");
                        repeat = false;
                        
                        break;
                }
            }
        }
    }
}
