using System;
using System.Collections.Generic;
using System.Linq;
using SFDL;
using SFModels;

namespace SFBL
{
    /// <summary>
    /// Handles all the business logic for the our store application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class ProductBL : IProductBL
    {
        private IRepository _repo;
        /// <summary>
        ///  Defining dependencies this class needs to operate
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public ProductBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        // public List<Inventory> GetInventoryById(int p_id)
        // {
        //     throw new NotImplementedException();
        // }


        public List<Product> GetProductById(int p_id)
        {
            List<Product> prodFound = _repo.GetProductById(p_id);
            if (prodFound == null)
            {
                throw new Exception("Store Inventory was not found!");
            }
            return prodFound;
        }

        public List<Product> GetAllProduct()
        {
            //Maybe my business operation needs to capitalize every name of a Customer
            List<Product> listOfProduct = _repo.GetAllProduct();
            for (int i = 0; i < listOfProduct.Count; i++)
            {
                 
                
            }

            return listOfProduct;
        }
    }
}