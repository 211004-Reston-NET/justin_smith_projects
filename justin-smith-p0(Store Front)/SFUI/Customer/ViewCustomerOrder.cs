using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ViewCustomerOrder : IMenu
    {
        private ISOrderBL _orderBL;
        public ViewCustomerOrder(ISOrderBL p_orderBL)
        {
            this._orderBL = p_orderBL;
        }

        public void Menu()
        {
            List<SOrder> orderList = _orderBL.GetCustomerOrderById(CustomerOrder._findCustOrder.CustId);
            if (orderList.Count == 0)
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
            foreach (SOrder order in orderList)
            {
                Console.WriteLine(order);
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
                        return MenuType.CustomerOrder;
                    default:
                        Console.WriteLine("Please input a valid response!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.ViewCustomerOrder;
                }
            }
        }
    }