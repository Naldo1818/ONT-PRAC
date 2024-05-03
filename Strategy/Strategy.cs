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
            return "Vehicle is Assemebled as follows:\nCarrier capabilities:Good and Driver\n";
        }
    }

    class Two_People_and_bag : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Vehicle is Assemebled as follows:\nCarrier Capabilties: 2 people max, and bag\n";
        }
    }

    class Five_People_and_luggage : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Vehicle is Assemebled as follows:\nCarrier Capabilties:5 people max, and few luggage\n";
        }
    }

    class Twenty_People : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Vehicle is Assemebled as follows:\nCarrier Capabilties:20 people max\n";
        }
    }

    class SixtyFive_People : VehicleAssemble
    {
        public override string GetDescription()
        {
            return "Vehicle is Assemebled as follows:\nCarrier Capabilties:65 people max\n";
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
            return vehicleAssemble.GetDescription() + "Engine size: Small engine\n";
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
            return vehicleAssemble.GetDescription() + "Engine size: Medium engine\n";
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
            return vehicleAssemble.GetDescription() + "Engine Size: Large engine\n";
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
            return vehicleAssemble.GetDescription() + "Engine Size: Extra large engine\n";
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
            return vehicleAssemble.GetDescription() + "Tow Capabilities: Cannot tow";
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
            return vehicleAssemble.GetDescription() + "Tow Capabilities: Can tow";
        }
    }
}


