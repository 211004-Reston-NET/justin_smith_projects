using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ShowStore : IMenu
    {
        private IStoreBL _storeBL;
        public static Store _findStore = new Store();
        public ShowStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {   
            Console.Clear();
            Console.WriteLine("\n====================");
            Console.WriteLine("List of Stores");
            Console.WriteLine("====================\n");

            List<Store> listOfStores = _storeBL.GetAllStore();

            foreach (Store store in listOfStores)
            {
                Console.WriteLine(store);
                Console.WriteLine("====================\n");
            }
            Console.WriteLine("[1] - Search for a Store by Name");
            Console.WriteLine("[2] - Search for a store by ID");
            Console.WriteLine("[3] - Search Store Inventories");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter a name for the Store you want to find");
                    _findStore.StoreName = Console.ReadLine();
                    return MenuType.CurrentStoreName;
                case "2":
                    Console.WriteLine("Enter an ID for the Store you want to find");
                    _findStore.StoreId = Int32.Parse(Console.ReadLine());
                    return MenuType.CurrentStoreId;
                case "3":
                    return MenuType.ShowInventory;

                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStore;
            }
        }
    }
}