using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class VanillaIceCream : IceCreamDecorator
    {
        private readonly IIceCreamCone? wrapee = null;

        public VanillaIceCream(IIceCreamCone wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }

        public VanillaIceCream() : base(wrapee: null)
        {
        }

        public override decimal GetCost()
        {
            if (this.wrapee != null)
            {
                return this.wrapee.GetCost() + 12;
            }
            return 12;
        }

        public override string GetDescription()
        {
            if (this.wrapee != null)
            {
                return wrapee.GetDescription() + "-" + "Vanilla";
            }

            return "Vanilla";
        }
    }
}
