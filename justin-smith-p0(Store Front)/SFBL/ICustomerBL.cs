using System.Collections.Generic;
using SFModels;

namespace SFBL
{
    public interface ICustomerBL
    {
         /// <summary>
        /// This will return a list of customers customerd in the database
        /// It will also capitalize every name of the customer
        /// </summary>
        /// <returns>It will return a list of customers</return>
        List<Customer> GetAllCustomer();

         /// <summary>
        /// Adds a Customer to the database
        /// </summary>
        /// <param name="p_customer">This is the customer we are adding</param>
        /// <returns>It returns the added customer</returns>

        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// Will find multiple customers given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find customers if their name has those letters</param>
        /// <returns>It will return customers it found</returns>

        List<Customer> GetCustomer(string p_name);

        /// <summary>
        ///  Will return a Customer based on the ID
        /// </summary>
        /// <param name="p_id">This is the ID it will check</param>
        /// <returns>Returns Customer it found</returns>
        
         List<Customer> GetCustomerEmail(string p_name);

        /// <summary>
        ///  Will return a Customer based on the ID
        /// </summary>
        /// <param name="p_id">This is the ID it will check</param>
        /// <returns>Returns Customer it found</returns>
        

        Customer GetCustomerById(int p_id);


        




    }
}
