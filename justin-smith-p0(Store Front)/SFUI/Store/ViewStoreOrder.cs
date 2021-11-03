using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ViewStoreOrder : IMenu
    {
        private ISOrderBL _orderBL;
        public ViewStoreOrder(ISOrderBL p_orderBL)
        {
            this._orderBL = p_orderBL;
        }

        public void Menu()
        {
            List<SOrder> orderList = _orderBL.GetStoreOrderById(StoreOrder._findStoreOrder.StoreId);


                Console.WriteLine("====================");
                foreach (SOrder order in orderList)
                {
                    Console.WriteLine(order);
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
                    return MenuType.StoreOrder;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ViewStoreOrder;
            }
        }
    }
}