using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Orders
{
    public interface IOrder
    {        
        float GetTotalPrice(string customerName, string productName, int quantity);       
    }
}
