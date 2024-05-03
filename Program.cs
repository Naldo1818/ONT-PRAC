using ONT_PRAC.Decorator;
using ONT_PRAC.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Strategy

            VehicleAssemble motorBike = new Two_People_and_bag();
            VehicleAssemble motorBike2 = new Good_Driver_Carrier();
            VehicleAssemble lightMotorVehicle = new Five_People_and_luggage();
            VehicleAssemble HeavyMotorVehicle = new Twenty_People();
            VehicleAssemble HeavyMotorVehicle3 = new SixtyFive_People();

                      
            motorBike = new Small_Engine(motorBike);
            motorBike = new CannotTow(motorBike);

            lightMotorVehicle = new Medium_Engine(lightMotorVehicle);
            lightMotorVehicle = new CanTow(lightMotorVehicle);

            HeavyMotorVehicle = new Large_Engine(HeavyMotorVehicle);
            HeavyMotorVehicle = new CannotTow(HeavyMotorVehicle);

            //HeavyMotorVehicle2 = new Extra_Large_Engine(HeavyMotorVehicle2);
            //HeavyMotorVehicle2 = new CanTow(HeavyMotorVehicle2);

            HeavyMotorVehicle3 = new Extra_Large_Engine(HeavyMotorVehicle3);
            HeavyMotorVehicle3 = new CanTow(HeavyMotorVehicle3);

            // Print descriptions of decorated vehicle assemblies              
            //Console.WriteLine(HeavyMotorVehicle2.GetDescription());
            //Console.WriteLine(HeavyMotorVehicle3.GetDescription());
                 
            Newsletter newsletter = new Newsletter();//calling the types of update notifications
            Diagnositics diagnositics = new Diagnositics();
            SoundSystem soundSystem = new SoundSystem();

            string VehicleChoice;
            Console.Write("What vehicle are you adding? (heavy, light, bike): ");
            VehicleChoice = Console.ReadLine();

            string SoundSystemChoice;
            Console.Write("Are you gonna add sound system? (Y/N): ");
            SoundSystemChoice = Console.ReadLine();

            string WIFIChoice;
            Console.Write("Are you gonna add WIFI? (Y/N): ");
            WIFIChoice = Console.ReadLine();
           
            
            string ChoiceCamera;
            Console.Write("Do you want to add a Camera to your Car (Y/N)? ");
            ChoiceCamera = Console.ReadLine();
            Console.WriteLine();  
          
          

            if (VehicleChoice.ToLower() =="light")
            {
                ObserverBase o1 = new ObserverBase("m");
                newsletter.Attach(o1);
                diagnositics.Attach(o1);
                soundSystem.Attach(o1);
                Strategy LMT = new LightMotorTechnician();//Decorator pattern  for the display

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower()=="y" && ChoiceCamera.ToLower() == "y")
                {
                    LMT = new LMT_SoundSystem(LMT);
                    LMT = new LMT_WiFi(LMT);
                    LMT = new LMT_Camera(LMT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Light Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "Light Motor Vehicle");
                    soundSystem.Notify("Update of Sound System", "Light Motor Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "y")
                {
                    LMT = new LMT_Camera(LMT);
                    LMT = new LMT_WiFi(LMT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Light Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "Light Motor Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {
                    LMT = new LMT_Camera(LMT);
                    LMT = new LMT_SoundSystem(LMT);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {
                    LMT = new LMT_SoundSystem(LMT);
                    LMT = new LMT_WiFi(LMT);
                    
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Light Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "Light Motor Vehicle");
                    soundSystem.Notify("Update of Sound System", "Light Motor Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {
                    
                    LMT = new LMT_WiFi(LMT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Light Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "Light Motor Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "n")
                {
                    LMT = new LMT_SoundSystem(LMT);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {

                    LMT = new LMT_Camera(LMT);
                    Console.WriteLine();

                }

                Console.WriteLine(LMT.Description() + "\nTotal Amount- " + LMT.Cost().ToString("C"));
                Console.WriteLine();
                Console.WriteLine(lightMotorVehicle.GetDescription());


                //Observer functions
                //observer pattern  for the display of uopdates for the vehicle
                
                
                newsletter.Detach(o1);
                diagnositics.Detach(o1);
                soundSystem.Detach(o1);
                Console.WriteLine();
                
                //end of light motor vehicle
            }

            if (VehicleChoice.ToLower() == "heavy")
            {
                ObserverBase o1 = new ObserverBase("m");
                newsletter.Attach(o1);
                diagnositics.Attach(o1);
                soundSystem.Attach(o1);
                Strategy HMT = new HeavyMotorTechnician();//Decorator pattern  for the display

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "y")
                {
                    HMT = new HMT_Camera(HMT);
                    HMT = new HMT_WiFi(HMT);
                    HMT = new HMT_SoundSystem(HMT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Heavy Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "HeavyMotor Vehicle");
                    soundSystem.Notify("Update of Sound System", "Heavy Motor Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "y")
                {
                    HMT = new HMT_Camera(HMT);
                    HMT = new HMT_WiFi(HMT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Heavy Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "Heavy Motor Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {
                    HMT = new HMT_Camera(HMT);
                    HMT = new HMT_SoundSystem(HMT);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {
                    HMT = new HMT_SoundSystem(HMT);
                    HMT = new HMT_WiFi(HMT);

                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Heavy Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "Heavy Motor Vehicle");
                    soundSystem.Notify("Update of Sound System", "Heavy Motor Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {

                    HMT = new LMT_WiFi(HMT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "Heavy Motor Vehicle");
                    newsletter.Notify("Discount of 20%", "Heavy Motor Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "n")
                {
                    HMT = new HMT_SoundSystem(HMT);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {

                    HMT = new HMT_Camera(HMT);
                    Console.WriteLine();

                }

                Console.WriteLine(HMT.Description() + "\nTotal Amount- " + HMT.Cost().ToString("C"));
                Console.WriteLine();
                Console.WriteLine(lightMotorVehicle.GetDescription());


                //Observer functions
                //observer pattern  for the display of uopdates for the vehicle


                newsletter.Detach(o1);
                diagnositics.Detach(o1);
                soundSystem.Detach(o1);
                Console.WriteLine();

                //end of light motor vehicle
            }

            if (VehicleChoice.ToLower() == "bike")
            {
                ObserverBase o1 = new ObserverBase("m");
                newsletter.Attach(o1);
                diagnositics.Attach(o1);
                soundSystem.Attach(o1);
                Strategy MBT = new MotorBikeTechnician();//Decorator pattern  for the display

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "y")
                {
                    MBT = new MBT_Camera(MBT);
                    MBT = new MBT_WiFi(MBT);
                    MBT = new MBT_SoundSystem(MBT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    soundSystem.Notify("Update of Sound System", "MotorBike Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "y")
                {
                    MBT = new MBT_Camera(MBT);
                    MBT = new MBT_WiFi(MBT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {
                    MBT = new MBT_Camera(MBT);
                    MBT = new MBT_SoundSystem(MBT);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {
                    MBT = new MBT_SoundSystem(MBT);
                    MBT = new MBT_WiFi(MBT);

                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    soundSystem.Notify("Update of Sound System", "MotorBike Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {

                    MBT = new MBT_WiFi(MBT);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "n")
                {
                    MBT = new MBT_SoundSystem(MBT);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {

                    MBT = new MBT_Camera(MBT);
                    Console.WriteLine();

                }

                Console.WriteLine(MBT.Description() + "\nTotal Amount- " + MBT.Cost().ToString("C"));
                Console.WriteLine();
                Console.WriteLine(motorBike.GetDescription());


                //Observer functions
                //observer pattern  for the display of uopdates for the vehicle


                newsletter.Detach(o1);
                diagnositics.Detach(o1);
                soundSystem.Detach(o1);
                Console.WriteLine();

                //end of Bike motor vehicle
            }
            Console.ReadLine();
        }
    }
}
