using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ShowProduct : IMenu
    {
        private IProductBL _productBL;
        public static Product _findProduct = new Product();

        public ShowProduct(IProductBL p_productBL)
        {
            _productBL = p_productBL;
        }
        public void Menu()
        {

            Console.WriteLine("\n====================");
            Console.WriteLine("List of Products");
            Console.WriteLine("====================\n");

            List<Product> listofProducts = _productBL.GetAllProduct();

            foreach (Product prod in listofProducts)
            {
                Console.WriteLine(prod);
                Console.WriteLine("====================\n");
            }
            {
                Console.WriteLine("[1] - View Product by ID");
                Console.WriteLine("[0] - Go Back");
            }
        }
        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "1":
                    Console.WriteLine("Enter an ID for the Store you want to find");
                    _findProduct.ProdId = Int32.Parse(Console.ReadLine());
                    return MenuType.CurrentProduct;
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStore;
            }
        }
    }
}
