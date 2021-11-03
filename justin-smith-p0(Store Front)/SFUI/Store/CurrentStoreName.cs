using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class CurrentStoreName : IMenu
    {
        private IStoreBL _storeBL;
        public CurrentStoreName(IStoreBL p_storeBL)
        {
            this._storeBL = p_storeBL;
        }

        public void Menu()
        {
            List<Store> listOfStore = _storeBL.GetStore(ShowStore._findStore.StoreName);


            Console.Clear();
            if(listOfStore.Count == 0)
            {   
                Console.WriteLine("\n====================");
                Console.WriteLine("No results found");
                Console.WriteLine("====================\n");
            }
            else
            {
                Console.WriteLine("\n====================");
                Console.WriteLine("Search Results");
                Console.WriteLine("====================\n");

            }

            foreach (Store store in listOfStore)
            {
                Console.WriteLine(store);
                Console.WriteLine("====================\n");
            }
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
                    return MenuType.CurrentStoreName;
            }
        }
    }
}