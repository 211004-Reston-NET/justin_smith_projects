using System.Collections.Generic;
using SFModels;

namespace SFBL
{
    public interface IProductBL
    {
        

        // /// <summary>
        // /// Will find multiple stores given a name
        // /// </summary>
        // /// <param name="p_name">This is the string it will check to find stores if their name has those letters</param>
        // /// <returns>It will return stores it found</returns>

        List<Product> GetProductById(int p_id);

        List<Product> GetAllProduct();

        




    }
}
