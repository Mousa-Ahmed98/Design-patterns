using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ChocolateIceCream : IIceCreamCone
    {
        public decimal GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Chocolate";
        }
    }
}
