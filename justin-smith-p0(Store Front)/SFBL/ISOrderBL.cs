using System.Collections.Generic;
using SFModels;

namespace SFBL
{
    public interface ISOrderBL 
    {
        

        // /// <summary>
        // /// Will find multiple stores given a name
        // /// </summary>
        // /// <param name="p_name">This is the string it will check to find stores if their name has those letters</param>
        // /// <returns>It will return stores it found</returns>

        List<SOrder> GetCustomerOrderById(int p_id);

        List<SOrder> GetStoreOrderById(int p_id);

        




    }
}
