using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class SearchStores : IMenu
    {
        private IStoreBL _storeBL;
        public static string _findStoreName;
        public SearchStores(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Stores");
            List<Store> listOfStores = _storeBL.GetAllStores();

            foreach (Store store in listOfStores)
            {
                Console.WriteLine("====================");
                Console.WriteLine(store);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for a Store");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddStore;
                case "0":
                    Console.WriteLine("Enter a name for the Store you want to find");
                    _findStoreName = Console.ReadLine();
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.SearchStores;
            }
        }
    }
}