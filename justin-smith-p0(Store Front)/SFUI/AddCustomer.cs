// using System;
// using SFBL;
// using SFModels;

// namespace SFUI
// {
//     public class AddCustomer : IMenu
//     {
//         private static Customer _cust = new Customer();
//         private ICustomerBL _custBL;

//         public AddCustomer(ICustomerBL p_custBL)
//         {
//             _custBL = p_custBL;
//         }

//         public void Menu()
//         {
//             Console.WriteLine("Adding a new Customer");
//             Console.WriteLine("Name - " + _cust.Name);
//             Console.WriteLine("Address - " + _cust.Address);
//             Console.WriteLine("Email - " + _cust.Email);
//             Console.WriteLine("Phone Number - " + _cust.PhoneNumber);
//             Console.WriteLine("Orders - " + _cust.Orders);
//             Console.WriteLine("[6] - Add Customer");
//             Console.WriteLine("[5] - Input value for Name");
//             Console.WriteLine("[4] - Input value for Address");
//             Console.WriteLine("[3] - Input value for Email");
//             Console.WriteLine("[2] - Input value for Phone Number");
//             Console.WriteLine("[1] - Input value for Orders");
//             Console.WriteLine("[0] - Go Back");
            
//         }

//         public MenuType YourChoice()
//         {
//             string userChoice = Console.ReadLine();
//             switch (userChoice)
//             {
//                 case "6":
//                     try
//                     {
//                         _custBL.AddCustomer(_store);
//                     }
//                     catch (System.Exception)
//                     {
//                         Console.WriteLine("You must input value to all the fields above");
//                         Console.WriteLine("Press Enter to continue");
//                         Console.ReadLine();
//                         return MenuType.AddCustomer;
//                     }
//                 case "5":
//                     Console.WriteLine("Type in the value for the Name");
//                     _cust.Name = Console.ReadLine();
//                     return MenuType.AddCustomer;
//                 case "4":
//                     Console.WriteLine("Type in the value of the Address");
//                     _cust.Address = Console.ReadLine();
//                     return MenuType.AddCustomer;
//                 case "3":
//                     Console.WriteLine("Type in the value of the Email");
//                     _cust.Email = Console.ReadLine();
//                     return MenuType.AddCustomer;
//                 case "2":
//                     Console.WriteLine("Type in the value of the Phone Number");
//                     _cust.PhoneNumber = Console.ReadLine();
//                     return MenuType.AddCustomer;
//                 case "1":
//                     Console.WriteLine("Type in the values of the Order");
//                     _cust.Orders = Console.ReadLine();
//                     return MenuType.AddCustomer;
//                 case "0":
//                     return MenuType.MainMenu; 
//                 default:
//                     Console.WriteLine("Please input a valid response!");
//                     Console.WriteLine("Press Enter to continue");
//                     Console.ReadLine();
//                     return MenuType.AddCustomer;
//             }
//         }
//     }
// }
