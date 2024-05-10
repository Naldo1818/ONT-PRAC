using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
     class HeavyMotorTechnician: Additions
    {
        public override string Description()
        {
            return "Heavy Motor Technician\nAdditions\n";
        }
        public override double Cost()
        {
            return 0;
        }
    }
}
