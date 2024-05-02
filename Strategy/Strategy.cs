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
            return "Carrier capabilities:Good and Driver\n";
        }
    }

    class Two_People_and_bag : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Carrier capabilities:2 people max, and bag\n";
        }
    }

    class Five_People_and_luggage : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Carrier capabilities:5 people max, and few luggage\n";
        }
    }

    class Twenty_People : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Carrier capabilities:20 people max\n";
        }
    }

    class SixtyFive_People : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Carrier capabilities:65 people max\n";
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
            return vehicleAssemble.GetDescription() + "Engine: has a small engine \n";
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
            return vehicleAssemble.GetDescription() + "Engine: has a medium engine\n";
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
            return vehicleAssemble.GetDescription() + "Engine: has a large engine\n";
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
            return vehicleAssemble.GetDescription() + "Engine: has an extra large engine\n";
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
            return vehicleAssemble.GetDescription() + "Towing capabilities: and cannot tow ";
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
            return vehicleAssemble.GetDescription() + "Towing capabilities: and can tow ";
        }
    }
}


