using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public static class DrinkFactory
    {
        public static HotDrink GetDrink(int option)
        {
            if (option == 1)
            {
                return new TeaDrink();
            }
            else if (option == 2)
            {
                return new NeskafeDrink();
            }
            else
            {
                return null;
            }
        }
    }
}
