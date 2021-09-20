using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Models;
using ProductLibrary.BusinessLogic;

namespace OrderLibrary.Products
{
    public class Product : IProductDbOp
    {
        IProductPL mProduct;

        public Product()
        {
            mProduct = new ProductHandler();
        }
        public int CreateProduct(int productId, string name, float price, int quantity, string description)
        {
            return mProduct.CreateProduct(productId, name, price, quantity, description);
        }

        public int GetProductPrice(string productName)
        {
            return mProduct.GetProductPrice(productName);
        }

        public int GetProductQuantity(string productName)
        {
            return mProduct.GetProductQuantity(productName);
        }

        public List<ProductInfo> LoadProducts()
        {
            return mProduct.LoadProducts();
        }
    }
}
