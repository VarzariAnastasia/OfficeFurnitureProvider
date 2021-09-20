using OrderLibrary.Rebates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Rebates
{
    public class CreationRebatesManager
    {
        static List<IRebate> instanceList = new List<IRebate>();
        public static void CreateRebates()
        {
            instanceList.Add(new QuantityRebate());
            instanceList.Add(new ChristmasRebate());
            instanceList.Add(new BlackFridayRebate());
        }

        public static List<IRebate> GetRebateInstances()
        {
            return instanceList;
        }
    }
}
