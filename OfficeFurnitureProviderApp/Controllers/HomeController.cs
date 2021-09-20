using OfficeFurnitureProviderApp.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using OrderLibrary.Customers;
using OrderLibrary.Products;
using OrderLibrary.Orders;
using System;
using OrderLibrary.Rebates;

namespace OfficeFurnitureProviderApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddCustomer()
        {
            ViewBag.Message = "Add a new customer";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCustomer(CustomerModel customer)
        {
            ICustomerDbOp mCustomer;
            if(ModelState.IsValid)
            {
                mCustomer = new Customer();
                //add verification
                try
                {
                    //if returns 1 - customer was successfully in the DB
                    int result = mCustomer.CreateCustomer(customer.CustomerId,
                    customer.Name,
                    customer.Rebate);
                    return RedirectToAction("ViewCustomers");
                }
                catch
                {
                    //handle exeption
                }                               
            }

            return View();
        }
        
        public ActionResult AddProduct()
        {
            ViewBag.Message = "Add a new product";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(ProductModel product)
        {
            IProductDbOp mProduct;
            if (ModelState.IsValid)
            {
                mProduct = new Product();
                try
                {
                    //result = 1 means that product was added successfully into DB
                    int result = mProduct.CreateProduct(product.ProductId,
                        product.Name,
                        product.Price,
                        product.Quantity,
                        product.Description);
                    return RedirectToAction("ViewProducts");
                }
                catch (Exception)
                { 
                    //handle exception
                }
            }

            return View();
        }

        public ActionResult ViewProducts()
        {
            ViewBag.Message = "Products List";
            IProductDbOp mProduct = new Product();
            List<ProductModel> productsVM = new List<ProductModel>();
            var products = mProduct.LoadProducts();

            foreach (var product in products)
            {
                productsVM.Add(new ProductModel
                {
                    ProductId = product.ProductId,
                    Name = product.ProductName,
                    Price = product.ProductPrice,
                    Quantity = product.ProductQuantity,
                    Description = product.ProductDescription
                });
            }

            return View(productsVM);
        }
        public ActionResult ViewCustomers()
        {
            ViewBag.Message = "Customers List";
            ICustomerDbOp mCustomer = new Customer();
            List<CustomerModel> customerVM = new List<CustomerModel>();
            var customers = mCustomer.LoadCustomers();            

            foreach (var customer in customers)
            {
                customerVM.Add(new CustomerModel
                {
                    CustomerId = customer.CustomerId,
                    Name = customer.CustomerName,
                    Rebate = customer.CustomerRebate
                });
            }          

            return View(customerVM);
        }

        public ActionResult ShopNow()
        {
            ViewBag.Message = "Do some shopping";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ShopNow(ShopNowModel shop)
        {            
            IOrder order = new OrderRequest(new CalculateGlobalRebate());
            try
            {
                shop.TotalPrice = order.GetTotalPrice(shop.Customer, shop.ProductName, shop.Quantity);
            }
            catch(Exception)
            {
                //handle exception
            }

            return RedirectToAction("ViewOrder", shop); 
        }


        public ActionResult ViewOrder(ShopNowModel shop)
        {
            ViewOrderModel viewOrder = new ViewOrderModel();
            viewOrder.Order = shop.Quantity.ToString() + " x " + shop.ProductName;
            viewOrder.TotalPrice = shop.TotalPrice;

            return View(viewOrder);
        }
    }
}