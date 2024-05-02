using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
    abstract class CondimentDecorator : Strategy //DecoratorBase
    {
        Strategy Additions = null;
        public CondimentDecorator(Strategy additions)
        {
            this.Additions = additions;
        }
        public override string Description()
        {
            return Additions.Description();
        }
    }
}
