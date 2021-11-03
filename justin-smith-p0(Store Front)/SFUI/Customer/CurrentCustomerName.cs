using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class CurrentCustomerName : IMenu
    {
        private ICustomerBL _custBL;
        public CurrentCustomerName(ICustomerBL p_custBL)
        {
            this._custBL = p_custBL;
        }

        public void Menu()
        {
            List<Customer> listOfCust = _custBL.GetCustomerName(ShowCustomer._findCust.CustName);
                Console.Clear();
            if(listOfCust.Count == 0)
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
            
            foreach (Customer cust in listOfCust)
            {
                
                Console.WriteLine(cust);
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
                    return MenuType.ShowCustomer;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentCustomerName;
            }
        }
    }
}
