using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class TeaDrink : HotDrink
    {
        public void Prepare()
        {
            Console.WriteLine("Boil Water");
            Console.WriteLine("Add Tea");
            Console.WriteLine("Add sugar");
            Console.WriteLine("Tea drink is ready now.");
        }
    }
}
