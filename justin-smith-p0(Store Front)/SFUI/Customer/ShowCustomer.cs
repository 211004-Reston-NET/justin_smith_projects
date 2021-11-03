using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ShowCustomer : IMenu
    {
        private ICustomerBL _custBL;
        public static Customer _findCust = new Customer();
        public ShowCustomer(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Customer");
            List<Customer> listOfCustomers = _custBL.GetAllCustomer();

            foreach (Customer cust in listOfCustomers)
            {
                Console.WriteLine("====================");
                Console.WriteLine(cust);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for a Customer by Name");
            Console.WriteLine("[2] - Search by Email");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
               
                case "1":
                    Console.WriteLine("Enter a name for the customer you want to find");
                    _findCust.CustName = Console.ReadLine();
                    return MenuType.CurrentCustomerName;
                case "2":
                    Console.WriteLine("Enter an email for the customer you want to find");
                    _findCust.CustEmail = Console.ReadLine();
                    return MenuType.CurrentCustomerEmail;
                
                case "5":
                    Console.WriteLine("Enter the ID of the Customer you want to find");

                    try
                    {
                         _findCust.CustId = Int32.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please put in a number!");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        return MenuType.ShowCustomer;
                    }
                    return MenuType.ShowCustomer;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomer;

                case "0":
                    return MenuType.CustomerMenu;
            }   
                
        }
    }
}