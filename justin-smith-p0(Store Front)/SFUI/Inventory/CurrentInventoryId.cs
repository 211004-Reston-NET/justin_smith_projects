using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class CurrentInventoryId : IMenu
    {
        private IInventoryBL _invBL;
        public CurrentInventoryId(IInventoryBL p_invBL)
        {
            this._invBL = p_invBL;
        }

        public void Menu()
        {
            Console.WriteLine(ShowInventory._findInventory.StoreId);
            List<Inventory> inventoryList = _invBL.GetInventoryById(ShowInventory._findInventory.StoreId);


                Console.WriteLine("====================");
                foreach (Inventory inv in inventoryList)
                {
                Console.WriteLine(inv);
                Console.WriteLine("====================");
                }
            
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
            
                case "0":
                    return MenuType.ShowInventory;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentInventoryId;
            }
        }
    }
}