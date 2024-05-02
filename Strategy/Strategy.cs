using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Decorator
{
    public abstract class VehicleAssemble
    {
        public abstract string GetDescription();
    }

    class Good_Driver_Carrier : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Heavy Motor Vehicle:\nGood and Driver";
        }
    }

    class Two_People_and_bag : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Motorbike Vehicle:\n2 people max, and bag";
        }
    }

    class Five_People_and_luggage : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Light Motor Vehicle:\n5 people max, and few luggage";
        }
    }

    class Twenty_People : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Light Motor Vehicle:\n20 people max";
        }
    }

    class SixtyFive_People : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Heavy Motor Vehicle:\n65 people max";
        }
    }

    class Small_Engine : VehicleAssemble
    {
        VehicleAssemble vehicleAssemble;
        public Small_Engine(VehicleAssemble vehicleAssemble)
        {
            this.vehicleAssemble = vehicleAssemble;
        }
        public override string GetDescription()
        {
            return vehicleAssemble.GetDescription() + ", has a small engine ";
        }
    }

    class Medium_Engine : VehicleAssemble
    {
        VehicleAssemble vehicleAssemble;
        public Medium_Engine(VehicleAssemble vehicleAssemble)
        {
            this.vehicleAssemble = vehicleAssemble;
        }
        public override string GetDescription()
        {
            return vehicleAssemble.GetDescription() + ", has a medium engine ";
        }
    }

    class Large_Engine : VehicleAssemble
    {
        VehicleAssemble vehicleAssemble;
        public Large_Engine(VehicleAssemble vehicleAssemble)
        {
            this.vehicleAssemble = vehicleAssemble;
        }
        public override string GetDescription()
        {
            return vehicleAssemble.GetDescription() + ", has a large engine ";
        }
    }

    class Extra_Large_Engine : VehicleAssemble
    {
        VehicleAssemble vehicleAssemble;
        public Extra_Large_Engine(VehicleAssemble vehicleAssemble)
        {
            this.vehicleAssemble = vehicleAssemble;
        }
        public override string GetDescription()
        {
            return vehicleAssemble.GetDescription() + ", has an extra large engine ";
        }
    }


    class CannotTow : VehicleAssemble
    {
        VehicleAssemble vehicleAssemble;
        public CannotTow(VehicleAssemble vehicleAssemble)
        {
            this.vehicleAssemble = vehicleAssemble;
        }
        public override string GetDescription()
        {
            return vehicleAssemble.GetDescription() + " and cannot tow ";
        }
    }

    class CanTow : VehicleAssemble
    {
        VehicleAssemble vehicleAssemble;
        public CanTow(VehicleAssemble vehicleAssemble)
        {
            this.vehicleAssemble = vehicleAssemble;
        }
        public override string GetDescription()
        {
            return vehicleAssemble.GetDescription() + " and can tow ";
        }
    }
}


