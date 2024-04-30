﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
    class MBT_Camera : CondimentDecorator
    {
        Additions additions;
        public MBT_Camera(Additions additions) : base(additions)
        {
            this.additions = additions;
        }
        public override string Description()
        {
            return additions.Description() + " Camera Added";
        }
        public override double Cost()
        {
            return additions.Cost() + 200;
        }
    }
}
