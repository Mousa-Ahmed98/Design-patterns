using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class IceCreamDecorator : IIceCreamCone
    {
        private readonly IIceCreamCone? Wrapee;

        public IceCreamDecorator(IIceCreamCone wrapee)
        {
            Wrapee = wrapee;
        }

        public virtual decimal GetCost()
        {
            return Wrapee.GetCost();
        }

        public virtual string GetDescription()
        {
            return Wrapee.GetDescription();
        }
    }
}
