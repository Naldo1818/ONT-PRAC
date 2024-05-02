using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
     class LightMotorTechnician:Strategy
    {
        public override string Description()
        {
            return "Light Motor Technician\nAdditions\n";
        }
        public override double Cost()
        {
            return 0;
        }
    }
}
