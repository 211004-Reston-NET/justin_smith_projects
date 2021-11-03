using System;
using SFBL;
using SFModels;

namespace SFUI
{
    public class AddCustomer : IMenu
    {
        private static Customer _customer = new Customer();
        private ICustomerBL _customerBL;
    

        public AddCustomer(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding a new Customer");
            Console.WriteLine("Name - " + _customer.CustName);
            Console.WriteLine("Address - " + _customer.CustAddress);
            Console.WriteLine("Email - " + _customer.CustEmail);
            Console.WriteLine("Phone - " + _customer.CustPhone);
            Console.WriteLine("[1] - Add Customer");
            Console.WriteLine("[2] - Input value for Name");
            Console.WriteLine("[3] - Input value for Address");
            Console.WriteLine("[4] - Input value for Email");
            Console.WriteLine("[5] - Input value for Phone");
            Console.WriteLine("[0] - Go Back");
            
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    try
                    {
                        _customerBL.AddCustomer(_customer);
                        Console.WriteLine("Customer Added");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all the fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddCustomer;
                    }
                    return MenuType.CustomerMenu;
                case "2":
                    Console.WriteLine("Type in the value for the Name");
                    _customer.CustName = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "3":
                    Console.WriteLine("Type in the value for the Address");
                    _customer.CustAddress = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "4":
                    Console.WriteLine("Type in the value of the Email");
                    _customer.CustEmail = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "5":
                    Console.WriteLine("Type in the value for the Phone");
                    _customer.CustPhone = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.CustomerMenu; 
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
            }
        }
    }
}
