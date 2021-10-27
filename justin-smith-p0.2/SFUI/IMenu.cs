namespace SFUI
{
    public enum MenuType
    {
        MainMenu,
        CustomerMenu,
        StoreMenu,
        ExitMenu,
        ShowStore
    }
    public interface IMenu
    {
        ///<summary>
        /// Will display the overall current menu class 
        /// and choice you/the user makes
        /// </summary>
        void Menu();

        /// <summary>
        ///  Will record the user's choice and change your menu based 
        /// on the end-user's choice
        /// </summary>

        MenuType YourChoice();


    }
}