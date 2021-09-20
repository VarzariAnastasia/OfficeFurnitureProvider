using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Rebates
{
    public class QuantityRebate : IRebate
    {
        public int GetRebate(int quantity = 1)
        {
            if (Enumerable.Range(1, 10).Contains(quantity))
            {
                return 10;
            }

            if (Enumerable.Range(11, 100).Contains(quantity))
            {
                return 20;
            }

            return 0;
        }
    }
}
