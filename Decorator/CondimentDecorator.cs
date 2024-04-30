using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
    abstract class CondimentDecorator : Additions //DecoratorBase
    {
        Additions Additions = null;
        public CondimentDecorator(Additions additions)
        {
            this.Additions = additions;
        }
        public override string Description()
        {
            return Additions.Description();
        }
    }
}
