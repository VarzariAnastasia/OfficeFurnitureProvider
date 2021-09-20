using CommonLibrary.Models;
using System.Collections.Generic;


namespace OrderLibrary.Customers
{
    public interface ICustomerDbOp
    {
        List<CustomerInfo> LoadCustomers();
        int CreateCustomer(int customerId, string name, int rebate);
        int GetCustomerRebate(string name);
    }
}
