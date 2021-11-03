using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ShowInventory : IMenu
    {
        private IInventoryBL _inventoryBL;
        public static Inventory _findInventory = new Inventory();

        public ShowInventory(IInventoryBL p_inventoryBL)
        {
            _inventoryBL = p_inventoryBL;
        }
        public void Menu()
        {   
            Console.WriteLine("[3] - View Store Inventory");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "3":
                    Console.WriteLine("Enter an ID for the Store you want to find");
                    _findInventory.StoreId = Int32.Parse(Console.ReadLine());
                    return MenuType.CurrentInventoryId;
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