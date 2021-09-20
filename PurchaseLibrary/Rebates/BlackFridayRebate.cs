using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Rebates
{
    public class BlackFridayRebate : IRebate
    {
        public int GetRebate(int quantity = 1)
        {
            return 10;
        }
    }
}
