using CommonLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary.BusinessLogic
{
    public interface ICustomerCL
    {
        List<CustomerInfo> LoadCustomers();
        int CreateCustomer(int customerId, string name, int rebate);
        int GetCustomerRebate(string customerName);
    }
}
