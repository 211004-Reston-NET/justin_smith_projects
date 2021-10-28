using System;
using SFBL;
using SFModels;

namespace SFUI
{
    public class AddStore : IMenu
    {
        private static Store _store = new Store();
        private IStoreBL _storeBL;
    

        public AddStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding a new Store");
            Console.WriteLine("Name - " + _store.Name);
            Console.WriteLine("Address - " + _store.Address);
            Console.WriteLine("[6] - Add Store");
            Console.WriteLine("[5] - Input value for Name");
            Console.WriteLine("[4] - Input value for Address");
            Console.WriteLine("[0] - Go Back");
            
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "6":
                    try
                    {
                        _storeBL.AddStore(_store);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all the fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddStore;
                    }
                    return MenuType.AddStore;
                case "5":
                    Console.WriteLine("Type in the value for the Name");
                    _store.Name = Console.ReadLine();
                    return MenuType.AddStore;
                case "4":
                    Console.WriteLine("Type in the value of the Address");
                    _store.Address = Console.ReadLine();
                    return MenuType.AddStore;
                case "0":
                    return MenuType.MainMenu; 
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddStore;
            }
        }
    }
}
