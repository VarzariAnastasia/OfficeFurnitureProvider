using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Rebates
{
    public interface IRebate
    {
        int GetRebate(int quantity = 1);
    }
}
