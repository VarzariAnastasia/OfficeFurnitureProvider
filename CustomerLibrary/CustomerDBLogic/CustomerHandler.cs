using CommonLibrary.Models;
using CustomerLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary.BusinessLogic
{
    public class CustomerHandler : ICustomerCL
    {
        public int CreateCustomer(int customerId, string name, int rebate)
        {
            CustomerInfo customer = new CustomerInfo
            {
                CustomerId = customerId,
                CustomerName = name,
                CustomerRebate = rebate
            };

            string sql = "insert into dbo.Customer (CustomerId, CustomerName, CustomerRebate) values (@CustomerId, @CustomerName, @CustomerRebate);";

            return SqlCustomersAccess.SaveCustomerData(sql, customer);
        }

        public List<CustomerInfo> LoadCustomers()
        {
            string sql = "select Id, CustomerId, CustomerName, CustomerRebate from dbo.Customer;";

            return SqlCustomersAccess.LoadCustomerData<CustomerInfo>(sql);
        }

        public int GetCustomerRebate(string customer)
        {
            string sql = "SELECT CustomerRebate FROM dbo.Customer WHERE CustomerName = @CustomerName;";

            return SqlCustomersAccess.GetCustomerRebate(sql, customer);
            
        }
    }
}
