using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class NeskafeDrink : HotDrink
    {
        public void Prepare()
        {
            Console.WriteLine("Boil Water");
            Console.WriteLine("Add Nesqafe");
            Console.WriteLine("Add sugar");
            Console.WriteLine("Neskafe drink is ready now.");
        }
    }
}
