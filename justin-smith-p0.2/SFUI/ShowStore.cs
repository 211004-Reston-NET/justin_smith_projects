using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ShowStore : IMenu
    {
        private StoreBL _storeBL;
        public ShowStore(StoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Stores");
            List<Store> listOfStores = _storeBL.GetAllStore();

            foreach(Store store in listOfStores)
            {
                Console.WriteLine("====================");
                Console.WriteLine(store);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
            Console.ReadLine();
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Invalid Choice. Press Enter to Continue");
                    Console.ReadLine();
                    return MenuType.ShowStore;
            }
        }
    }
}