using OrderLibrary.Customers;
using OrderLibrary.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Models;
using OrderLibrary.Products;
using OrderLibrary.Rebates;

namespace OrderLibrary.Orders
{
    public class OrderRequest : IOrder
    {       
        IProductDbOp mProduct;
        ICalculateRebate mCalculateRebate;
        public OrderRequest(ICalculateRebate rebate)
        {            
            mProduct = new Product();
            mCalculateRebate = rebate;
        }
        
        public float GetTotalPrice(string customerName, string productName, int quantity)
        {
            if (!checkProductQuantity(productName, quantity))
            {
                throw new Exception("Insufficient stock!");
            }

            int customerRebate = getCustomerRebate(customerName, productName, quantity);
            int productPrice = mProduct.GetProductPrice(productName);


            float priceWithRebate = productPrice - (productPrice * customerRebate) / 100;
            float totalPrice = priceWithRebate * quantity;

            return totalPrice;
        }

        private int getCustomerRebate(string customerName, string productName, int quantity)
        {            
            try
            {
                return mCalculateRebate.CalculateRebate(customerName, productName, quantity);
            }
            catch
            {
                //handle exception
            }
            return 0;
        }

        private bool checkProductQuantity(string productName, int quantity)
        {            
            try
            {
                int productQuantity = mProduct.GetProductQuantity(productName);
                if (productQuantity < quantity)
                {
                    return false;
                }
            }
            catch
            {
                //handle exception
                return false;
            }

            return true;
        }
                  
    }
}
