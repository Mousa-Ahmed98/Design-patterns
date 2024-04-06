using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StrawberryIceCream : IceCreamDecorator
    {
        private readonly IIceCreamCone? wrapee = null;

        public StrawberryIceCream(IIceCreamCone wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }

        public StrawberryIceCream() : base(wrapee: null)
        {
        }

        public override decimal GetCost()
        {
            if (this.wrapee != null)
            {
                return this.wrapee.GetCost() + 14;
            }
            return 12;
        }

        public override string GetDescription()
        {
            if (this.wrapee != null)
            {
                return wrapee.GetDescription() + "-" + "Strawberry";
            }

            return "Strawberry";
        }
    }
}
