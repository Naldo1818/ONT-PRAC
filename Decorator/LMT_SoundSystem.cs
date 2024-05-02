﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
    class LMT_SoundSystem : CondimentDecorator
    {
        Strategy additions;
        public LMT_SoundSystem(Strategy additions) : base(additions)
        {
            this.additions = additions;
        }
        public override string Description()
        {
            return additions.Description() + " Sound System Added";
        }
        public override double Cost()
        {
            return additions.Cost() + 1200;
        }
    }
}
