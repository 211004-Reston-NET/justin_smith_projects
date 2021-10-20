using System.Collections.Generic;
using SFModels;

namespace SFDL
{
    public class IRepository
    {
        /// <summary>
        /// It will add a store in our database
        /// </summary>
        /// <param name="p_store">This is the store we will be adding to the database</param>
        /// <returns>It will just return the store we are adding</returns>
        Store AddStore(Store p_store);

        /// <summary>
        /// This will return a list of stores stored in the database
        /// </summary>
        /// <returns>It will return a list of store</returns>
        List<Store> GetAllStores();

    }
}
