using OrderLibrary.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Rebates
{
    public class CalculateGlobalRebate : ICalculateRebate
    {     
        ICustomerDbOp mCustomer;    
         
        public CalculateGlobalRebate()
        {
            mCustomer = new Customer();            
        }
     
        public int CalculateRebate(string customerName, string productName, int quantity)
        {                                   
            int rebate = getDBCutomerRebate(customerName);
            foreach (var item in CreationRebatesManager.GetRebateInstances())
            {
                if (item is QuantityRebate)
                {
                    rebate += item.GetRebate(quantity);
                }
                else
                {
                    rebate += item.GetRebate();
                }
            }

            return rebate;
        }

        private int getDBCutomerRebate(string customerName)
        {
            try
            {
                return mCustomer.GetCustomerRebate(customerName);
            }
            catch (Exception)
            {
                //handle exception
                return 0;
            }
        }
    }
}
