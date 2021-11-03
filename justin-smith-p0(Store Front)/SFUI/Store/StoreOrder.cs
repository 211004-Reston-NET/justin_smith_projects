using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class StoreOrder : IMenu
    {
        private ISOrderBL _orderBL;
        public static SOrder _findStoreOrder = new SOrder();
        public StoreOrder(ISOrderBL p_orderBL)
        {
            _orderBL = p_orderBL;
        }
        public void Menu()
        {
            // Console.WriteLine("List of Customer");
            // List<Customer> listOfCustomers = _orderBL.GetAllCustomer();

            // foreach (Customer cust in listOfCustomers)
            // {
            //     Console.WriteLine("====================");
            //     Console.WriteLine(cust);
            //     Console.WriteLine("====================");
            // }
            Console.WriteLine("[1] - Get orders by Store ID");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
               
               case "1":
                    Console.WriteLine("Enter an ID for the Store you want to find");
                    _findStoreOrder.StoreId = Int32.Parse(Console.ReadLine());
                    return MenuType.ViewStoreOrder;
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreOrder;

                
            }   
                
        }
    }
}