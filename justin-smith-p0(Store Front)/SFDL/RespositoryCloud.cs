using System.Collections.Generic;
using System.Linq;
using SFModels;
using Entity = SFDL.Entities;
using Model = SFModels;

namespace SFDL
{
    public class RespositoryCloud : IRepository
    {
        private Entity.SFDataBaseContext _context;
        public RespositoryCloud(Entity.SFDataBaseContext p_context) 
        {
            _context = p_context;
        }


        public Model.Customer AddCustomer(Model.Customer p_customer)
        {
            _context.Customers.Add
            (
                new Entity.Customer()
                {
                    CustName = p_customer.CustName,
                    CustAddress = p_customer.CustAddress,
                    CustEmail = p_customer.CustEmail,
                    CustPhone = p_customer.CustPhone

                }
            );

            //This method will save the changes made to the database
            _context.SaveChanges();

            return p_customer;
        }

        public List<Model.Store> GetAllStore()
        {
            //Method Syntax
            return _context.Stores.Select(store => 
                new Model.Store()
                {
                    StoreId = store.StoreId,
                    StoreName = store.StoreName,
                    StoreAddress = store.StoreAddress,
                    StorePhone = store.StorePhone

                }
            ).ToList();


            //Query Syntax
            // var result = (from rest in _context.Restaurants
            //             select rest);

            // List<Model.Restaurant> listOfRest = new List<Model.Restaurant>();
            // foreach (var rest in result)
            // {
            //     listOfRest.Add(new Model.Restaurant(){
            //         Name = rest.RestName,
            //         State = rest.RestState,
            //         City = rest.RestCity,
            //         Id = rest.RestId
            //     });
            // }

            // return listOfRest;
        }

        public List<Model.Store> GetStoreById(int p_id)
        {

            return _context.Stores 
                                .Where(stor => stor.StoreId == p_id)
                                .Select(store =>
            new Model.Store()
            {
                StoreId = store.StoreId,
                StoreName = store.StoreName,
                StoreAddress = store.StoreAddress,
                StorePhone = store.StorePhone
            }).ToList();
            
        }

        public List<Model.SOrder> GetStoreOrderById(int p_id)
        {

            return _context.SOrders
                                .Where(ord => ord.StoreId == p_id)
                                .Select(order => 
                new Model.SOrder()
                {   
                    OrderId = order.OrderId,
                    StoreId = order.StoreId,
                    CustId = order.CustId,
                    OrderPrice = order.OrderPrice
                }
            ).ToList();
        
        }

        public Model.Customer GetCustomerById(int p_id)
        {
            Entity.Customer customerToFind = _context.Customers.Find(p_id);
            
            return new Model.Customer()
            {
                CustId = customerToFind.CustId,
                CustName = customerToFind.CustName,
                CustAddress = customerToFind.CustAddress,
                CustEmail = customerToFind.CustEmail,
                CustPhone = customerToFind.CustPhone
            };

        }

        // public Model.SOrder GetOrderById(int p_id)
        // {
        //     Entity.SOrder orderToFind = _context.SOrders.Find(p_id);
            
        //     return new Model.SOrder()
        //     {
        //         OrderId = orderToFind.OrderId,
        //         StoreId = orderToFind.StoreId,
        //         CustId = orderToFind.CustId,
        //         OrderPrice = orderToFind.OrderPrice,
        //     };  
        // }


        


        public List<Model.SOrder> GetCustomerOrderById(int p_id)
        {

            return _context.SOrders
                                .Where(ord => ord.CustId == p_id)
                                .Select(order => 
                new Model.SOrder()
                {   
                    OrderId = order.OrderId,
                    StoreId = order.StoreId,
                    CustId = order.CustId,
                    OrderPrice = order.OrderPrice
                }
            ).ToList();
        
        }


        public List<Model.Inventory> GetInventoryById(int p_id)
        {
            // Entity.Inventory inventoryToFind = _context.Inventories.FirstOrDefault(inv => inv.StoreId == p_id );


            return _context.Inventories
                                .Where(inv => inv.StoreId == p_id)
                                .Select(inventory => 
                new Model.Inventory()
                {
                    StoreId = inventory.StoreId,
                    ProdId = inventory.ProdId,
                    Stock = inventory.Stock
                }
            ).ToList();
        
        }

        public List<Model.Product> GetProductById(int p_id)
        {


            return _context.Products
                                .Where(prod => prod.ProdId == p_id)
                                .Select(product => 
                new Model.Product()
                {
                    ProdId = product.ProdId,
                    ProdName = product.ProdName,
                    ProdPrice = product.ProdPrice,
                    ProdDescription = product.ProdDescription
                }
            ).ToList();
        
        }



        

        public List<Model.Customer> GetAllCustomer()
        {
            //Method Syntax
            return _context.Customers.Select(customer => 
                new Model.Customer()
                {
                CustId = customer.CustId,
                CustName = customer.CustName,
                CustAddress = customer.CustAddress,
                CustEmail = customer.CustEmail,
                CustPhone = customer.CustPhone

                }
            ).ToList();

        }

        public List<Model.Product> GetAllProduct()
        {
            //Method Syntax
            return _context.Products.Select(product => 
                new Model.Product()
                {
                ProdId = product.ProdId,
                ProdName = product.ProdName,
                ProdPrice = product.ProdPrice,
                ProdDescription = product.ProdDescription,
                }
            ).ToList();

        }

       






        // public List<Model.Review> GetAllReview(Model.Restaurant p_rest)
        // {
        //     //Query syntax
        //     // var result = (from rev in _context.Reviews
        //     //             where rev.RestId == p_rest.Id
        //     //             select rev);

        //     // //Mapping the Queryable<Entity.Review> into a list<Model.Review>
        //     // List<Model.Review> listOfReview = new List<Model.Review>();
        //     // foreach (Entity.Review rev in result)
        //     // {
        //     //     listOfReview.Add(new Model.Review(){
        //     //         Id = rev.RevId,
        //     //         Rating = rev.RevRating,
        //     //         RestId = rev.RestId
        //     //     });
        //     // }

        //     // return listOfReview;

        //     //Method Syntax - since this looks cleaner
        //     return _context.Reviews
        //         .Where(rev => rev.RevId == p_rest.Id) //We find the reviews that have matching restId
        //         .Select(rev => new Model.Review(){ //Convert it into Model.Review
        //           Id = rev.RevId,
        //           Rating = rev.RevRating,
        //           Restaurant = p_rest
        //         })
        //         .ToList(); //Convert it into List

    }
}