using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
    abstract class AdditionsDecorator : Additions //DecoratorBase
    {
        Additions Additions = null;
        public AdditionsDecorator(Additions additions)
        {
            this.Additions = additions;
        }
        public override string Description()
        {
            return Additions.Description();
        }
    }
}
