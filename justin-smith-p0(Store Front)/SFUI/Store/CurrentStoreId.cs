using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class CurrentStoreId : IMenu
    {
        private IStoreBL _storeBL;
        public CurrentStoreId(IStoreBL p_storeBL)
        {
            this._storeBL = p_storeBL;
        }

        public void Menu()
        {
            Store store = _storeBL.GetStoreById(ShowStore._findStore.StoreId);


                Console.WriteLine("====================");
                Console.WriteLine(store);
                Console.WriteLine("====================");
            
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuType.ShowStore;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentStoreId;
            }
        }
    }
}