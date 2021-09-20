using CommonLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.BusinessLogic
{
    public interface IProductPL
    {
        List<ProductInfo> LoadProducts();
        int CreateProduct(int productId, string name, float price, int quantity, string description);
        int GetProductPrice(string productName);
        int GetProductQuantity(string productName);
    }
}
