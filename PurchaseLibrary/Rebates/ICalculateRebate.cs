using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Rebates
{
    public interface ICalculateRebate
    {
        int CalculateRebate(string customerName, string productName, int quantity);
    }
}
