using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class CurrentProduct : IMenu
    {
        private IProductBL _prodBL;
        public CurrentProduct(IProductBL p_prodBL)
        {
            this._prodBL = p_prodBL;
        }

        public void Menu()
        {
            List<Product> productList = _prodBL.GetProductById(ShowProduct._findProduct.ProdId);

            if(productList.Count == 0)
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
            foreach (Product prod in productList)
            {
                Console.WriteLine(prod);
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
                    return MenuType.ShowProduct;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentInventoryId;
            }
        }
    }
}