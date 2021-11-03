using System.Collections.Generic;
using SFModels;

namespace SFDL
{
    public interface IRepository
    {
        /// <summary>
        /// It will add a store in our database
        /// </summary>
        /// <param name="p_store">This is the store we will be adding to the database</param>
        /// <returns>It will just return the store we are adding</returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// This will return a list of stores stored in the database
        /// </summary>
        /// <returns>It will return a list of store</returns>
        List<Store> GetAllStore();

        /// <summary>
        /// This will give a specific store based on ID
        /// </summary>
        /// <param name="p_id">This is the ID it will look for</param>
        /// <returns>Returns the Store</returns>
        List<Store> GetStoreById(int p_id);

        Customer GetCustomerById(int p_id);

        List<Customer> GetAllCustomer();

        List<Product> GetAllProduct();

        List<Inventory> GetInventoryById(int p_id);

        List<SOrder> GetStoreOrderById(int p_id);

        List<SOrder> GetCustomerOrderById(int p_id);

        List<Product> GetProductById(int p_id);



        
    }
}
