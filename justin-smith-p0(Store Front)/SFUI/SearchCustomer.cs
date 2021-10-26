// using System;
// using System.Collections.Generic;
// using SFBL;
// using SFModels;

// namespace SFUI
// {
//     public class SearchCustomer : IMenu
//     {
//         private ICustomerBL _custBL;
//         public static string _findCustName;
//         public ShowCustomer(ICustomerBL p_custBL)
//         {
//             _custBL = p_custBL;
//         }
//         public void Menu()
//         {
//             Console.WriteLine("List of Stores");
//             List<Customer> listOfCustomers = _custBL.GetAllCustomers();

//             foreach (Customer cust in listOfCustomers)
//             {
//                 Console.WriteLine("====================");
//                 Console.WriteLine(cust);
//                 Console.WriteLine("====================");
//             }
//             Console.WriteLine("[1] - Search for a Customer");
//             Console.WriteLine("[0] - Go Back");
//         }

//         public MenuType YourChoice()
//         {
//             string userChoice = Console.ReadLine();
//             switch (userChoice)
//             {
//                 case "0":
//                     return MenuType.AddCustomer;
//                 case "1":
//                     Console.WriteLine("Enter a name for the Customer you want to find");
//                     _findCustName = Console.ReadLine();
//                     return MenuType.CustomerMenu;
//                 default:
//                     Console.WriteLine("Please input a valid response!");
//                     Console.WriteLine("Press Enter to continue");
//                     Console.ReadLine();
//                     return MenuType.SearchCustomers;
//             }
//         }
//     }
// }