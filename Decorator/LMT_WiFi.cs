﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
    class LMT_WiFi : AdditionsDecorator
    {
        Additions additions;
        public LMT_WiFi(Additions additions) : base(additions)
        {
            this.additions = additions;
        }
        public override string Description()
        {
            return additions.Description() + " Wi-Fi Added";
        }
        public override double Cost()
        {
            return additions.Cost() + 950;
        }
    }
}
