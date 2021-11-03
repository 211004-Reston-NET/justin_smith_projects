using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SFBL;
using SFDL;
using SFDL.Entities;

namespace SFUI
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //Gets the current directory of the SFUI file path
                .AddJsonFile("appsetting.json") //Adds the appsetting.json file in our SFUI
                .Build(); //Builds our configuration

            DbContextOptions<SFDataBaseContext> options = new DbContextOptionsBuilder<SFDataBaseContext>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();

                case MenuType.AddCustomer:
                    return new AddCustomer(new CustomerBL(new RespositoryCloud(new SFDataBaseContext(options))));
                 case MenuType.ShowCustomer:
                    return new ShowCustomer(new CustomerBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.CurrentCustomerName:
                    return new CurrentCustomerName(new CustomerBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.CurrentCustomerEmail:
                    return new CurrentCustomerEmail(new CustomerBL(new RespositoryCloud(new SFDataBaseContext(options))));

                case MenuType.ShowStore:
                    return new ShowStore(new StoreBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.CurrentStoreId:
                    return new CurrentStoreId(new StoreBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.CurrentStoreName:
                    return new CurrentStoreName(new StoreBL(new RespositoryCloud(new SFDataBaseContext(options))));
                
                case MenuType.CustomerOrder:
                    return new CustomerOrder(new SOrderBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.ViewCustomerOrder:
                    return new ViewCustomerOrder(new SOrderBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.StoreOrder:
                    return new StoreOrder(new SOrderBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.ViewStoreOrder:
                    return new ViewStoreOrder(new SOrderBL(new RespositoryCloud(new SFDataBaseContext(options))));
                

                case MenuType.ShowInventory:
                    return new ShowInventory(new InventoryBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.CurrentInventoryId:
                    return new CurrentInventoryId(new InventoryBL(new RespositoryCloud(new SFDataBaseContext(options))));

                case MenuType.CurrentProduct:
                    return new CurrentProduct(new ProductBL(new RespositoryCloud(new SFDataBaseContext(options))));
                case MenuType.ShowProduct:
                    return new ShowProduct(new ProductBL(new RespositoryCloud(new SFDataBaseContext(options))));

                default:
                    return null;
            }
        }
    }
}