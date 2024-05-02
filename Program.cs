using ONT_PRAC.Decorator;
using ONT_PRAC.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Strategy
            VehicleAssemble motorBike = new Two_People_and_bag();
            VehicleAssemble lightMotorVehicle = new Five_People_and_luggage();
            VehicleAssemble HeavyMotorVehicle = new Twenty_People();
            VehicleAssemble HeavyMotorVehicle2 = new Good_Driver_Carrier();
            VehicleAssemble HeavyMotorVehicle3 = new SixtyFive_People();


            motorBike = new Small_Engine(motorBike);
            motorBike = new CannotTow(motorBike);

            lightMotorVehicle = new Medium_Engine(lightMotorVehicle);
            lightMotorVehicle = new CanTow(lightMotorVehicle);

            HeavyMotorVehicle = new Large_Engine(HeavyMotorVehicle);
            HeavyMotorVehicle = new CannotTow(HeavyMotorVehicle);

            HeavyMotorVehicle2 = new Extra_Large_Engine(HeavyMotorVehicle2);
            HeavyMotorVehicle2 = new CanTow(HeavyMotorVehicle2);

            HeavyMotorVehicle3 = new Extra_Large_Engine(HeavyMotorVehicle3);
            HeavyMotorVehicle3 = new CanTow(HeavyMotorVehicle3);

            // Print descriptions of decorated vehicle assemblies              
             //Console.WriteLine(HeavyMotorVehicle2.GetDescription());
            //Console.WriteLine(HeavyMotorVehicle3.GetDescription());
                 
            Newsletter newsletter = new Newsletter();//calling the types of update notifications
            Diagnositics diagnositics = new Diagnositics();
            SoundSystem soundSystem = new SoundSystem();

            string Choice;
            Choice = Console.Write("Do you want to add a Camera to your Car? (Y/N) "))

            Strategy LMTwithSoundAndWifi = new LightMotorTechnician();//Decorator pattern  for the display
            LMTwithSoundAndWifi = new LMT_SoundSystem(LMTwithSoundAndWifi);
            LMTwithSoundAndWifi = new LMT_WiFi(LMTwithSoundAndWifi);
            Console.WriteLine(LMTwithSoundAndWifi.Description() + "\nTotal Amount- " + LMTwithSoundAndWifi.Cost().ToString("C"));
            Console.WriteLine(lightMotorVehicle.GetDescription());
            ObserverBase o1 = new ObserverBase("m");//observer pattern  for the display of uopdates for the vehicle
            newsletter.Attach(o1);
            diagnositics.Attach(o1);
            soundSystem.Attach(o1);
            diagnositics.Notify("Diagnosis", "Light Motor Vehicle");
            newsletter.Notify("Discount of 20%", "Light Motor Vehicle");
            soundSystem.Notify("Update of Sound System", "Light Motor Vehicle");
            newsletter.Detach(o1);
            diagnositics.Detach(o1);
            soundSystem.Detach(o1);
            Console.WriteLine();

            Strategy HMTwithWifiAndCameraAndSound = new HeavyMotorTechnician();//Decorator pattern  for the display
            HMTwithWifiAndCameraAndSound = new HMT_Camera(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_WiFi(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_SoundSystem(HMTwithWifiAndCameraAndSound);
            Console.WriteLine(HMTwithWifiAndCameraAndSound.Description() + "\nTotal Amount - " + HMTwithWifiAndCameraAndSound.Cost().ToString("C"));

            Console.WriteLine(HeavyMotorVehicle.GetDescription());

            ObserverBase o2 = new ObserverBase("m");//observer pattern  for the display of uopdates for the vehicle
            newsletter.Attach(o2);
            diagnositics.Attach(o2);
            soundSystem.Attach(o2);
            diagnositics.Notify("Diagnosis", "Heavy Motor Vehicle");
            newsletter.Notify("Discount of 20%", "Heavy Motor Vehicle");
            soundSystem.Notify("Update of Sound System", "Heavy Motor Vehicle");
            newsletter.Detach(o2);
            diagnositics.Detach(o2);
            soundSystem.Detach(o2);
            Console.WriteLine();

            Strategy MBTwithWifi = new MotorBikeTechnician();
            MBTwithWifi = new LMT_SoundSystem(MBTwithWifi);
            Console.WriteLine(MBTwithWifi.Description() + "\nTotal Amount- " + MBTwithWifi.Cost().ToString("C"));
            Console.WriteLine(motorBike.GetDescription());
            //ObserverBase o3 = new ObserverBase("m");//observer pattern  for the display of uopdates for the vehicle 
            //newsletter.Attach(o3);
            //diagnositics.Attach(o3);
            //diagnositics.Notify("Diagnosis", "Motorbike");
            //newsletter.Notify("Discount of 20%", "Motorbike");
            //newsletter.Detach(o3);
            //diagnositics.Detach(o3);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
