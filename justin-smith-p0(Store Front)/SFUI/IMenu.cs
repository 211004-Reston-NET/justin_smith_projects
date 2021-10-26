namespace SFUI
{

    public enum MenuType
    {
        MainMenu,
        CustomerMenu,
        StoreMenu,
        AddCustomer,
        SearchCustomers,
        SearchStores,
        PlaceOrder,
        ViewOrder,
        AddStore,
        OrderMenu,
        ProductMenu,
        
        Exit,
    }

public interface IMenu
    {

        /// <summary>
        /// Will display the overall menu of the current menu class 
        /// and the choice you/the user can make
        /// </summary>
        void Menu();

        /// <summary>
        /// Will record the user's choice and change your menu based
        /// on the end-user's choice
        /// </summary>
        /// <returns>This method should return a menu that the user will go to next</returns>
        MenuType YourChoice();


        
    }
}
