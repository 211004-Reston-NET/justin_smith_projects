using System.Collections.Generic;
using SFModels;

namespace SFBL
{
    public interface IStoreBL
    {
         /// <summary>
        /// This will return a list of stores stored in the database
        /// It will also capitalize every name of the store
        /// </summary>
        /// <returns>It will return a list of stores</return>
        List<Store> GetAllStore();

         /// <summary>
        /// Adds a store to the database
        /// </summary>
        /// <param name="p_store">This is the store we are adding</param>
        /// <returns>It returns the added store</returns>

        // Store AddStore(Store p_store);

        // /// <summary>
        // /// Will find multiple stores given a name
        // /// </summary>
        // /// <param name="p_name">This is the string it will check to find stores if their name has those letters</param>
        // /// <returns>It will return stores it found</returns>

        List<Store> GetStore(string p_name);

        /// <summary>
        ///  Will return a store based on the ID
        /// </summary>
        /// <param name="p_id">This is the ID it will check</param>
        /// <returns>Returns store it found</returns>

        List<Store> GetStoreById(int p_id);

        




    }
}
