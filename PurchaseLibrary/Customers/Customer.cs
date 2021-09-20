using CommonLibrary.Models;
using CustomerLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Customers
{
    public class Customer : ICustomerDbOp
    {
        ICustomerCL mCustomer;
        public Customer()
        {
            mCustomer = new CustomerHandler();
        }
        public int CreateCustomer(int customerId, string name, int rebate)
        {            
            return mCustomer.CreateCustomer(customerId, name, rebate);
        }       

        public List<CustomerInfo> LoadCustomers()
        {            
            return mCustomer.LoadCustomers();
        }

        public int GetCustomerRebate(string name)
        {
            return mCustomer.GetCustomerRebate(name);
        }
    }
}
