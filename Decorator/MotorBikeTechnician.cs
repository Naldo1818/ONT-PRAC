using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
     class MotorBikeTechnician:Additions
    {
        public override string Description()
        {
            return "Motor Bike Technician\nAdditions\n";
        }
        public override double Cost()
        {
            return 0;
        }
    }
}
