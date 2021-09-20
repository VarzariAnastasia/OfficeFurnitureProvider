using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Rebates
{
    public class ChristmasRebate : IRebate
    { 
        public int GetRebate(int quantity = 1)
        {
            return 5;
        }
    }
}
