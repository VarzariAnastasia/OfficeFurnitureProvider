using CommonLibrary.Models;
using ProductLibrary.DataAccess;
using System.Collections.Generic;

namespace ProductLibrary.BusinessLogic
{
    public class ProductHandler : IProductPL
    {
        public int CreateProduct(int productId, string name, float price, int quantity, string description)
        {
            ProductInfo customer = new ProductInfo
            {
                ProductId = productId,
                ProductName = name,
                ProductPrice = price,
                ProductQuantity = quantity,
                ProductDescription = description
            };

            string sql = "insert into dbo.Product (ProductId, ProductName, ProductPrice, ProductQuantity, ProductDescription) values (@ProductId, @ProductName, @ProductPrice, @ProductQuantity, @ProductDescription);";

            return SqlProductsAccess.SaveProductData(sql, customer);
        }

        public List<ProductInfo> LoadProducts()
        {
            string sql = "select Id, ProductId, ProductName, ProductPrice, ProductQuantity, ProductDescription from dbo.Product;";

            return SqlProductsAccess.LoadProductData<ProductInfo>(sql);
        }

        public int GetProductPrice(string productName)
        {
            string sql = "SELECT ProductPrice FROM dbo.Product WHERE ProductName = @ProductName;";

            return SqlProductsAccess.GetProductPrice(sql, productName);

        }

        public int GetProductQuantity(string productName)
        {
            string sql = "SELECT ProductQuantity FROM dbo.Product WHERE ProductName = @ProductName;";

            return SqlProductsAccess.GetProductQuantity(sql, productName);

        }
    }
}
