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

           

            HeavyMotorVehicle3 = new Extra_Large_Engine(HeavyMotorVehicle3);
            HeavyMotorVehicle3 = new CanTow(HeavyMotorVehicle3);

            // Print descriptions of decorated vehicle assemblies              
            //Console.WriteLine(HeavyMotorVehicle2.GetDescription());
            //Console.WriteLine(HeavyMotorVehicle3.GetDescription());
                 
            Newsletter newsletter = new Newsletter();//calling the types of update notifications
            Diagnositics diagnositics = new Diagnositics();
            SoundSystem soundSystem = new SoundSystem();

            string VehicleChoice;
            Console.WriteLine("Vehicle Assemble");
            Console.WriteLine("================================================");

            Console.Write("What vehicle are you adding? (heavy, light, bike): ");
            VehicleChoice = Console.ReadLine();
            Console.WriteLine();

            if (VehicleChoice == "heavy" || VehicleChoice == "Heavy")
            {
                Console.WriteLine("Add extra features to you Heavy Motor Vehicle");
            }

            else if (VehicleChoice == "light" || VehicleChoice == "Light")
            {
                Console.WriteLine("Add extra features to you Light Motor Vehicle");
            }

            else if(VehicleChoice == "bike" || VehicleChoice == "Bike")
            {
                Console.WriteLine("Add extra features to you Motorbike Vehicle");
            }

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
                Notification o1 = new Notification("m");
                newsletter.Attach(o1);
                diagnositics.Attach(o1);
                soundSystem.Attach(o1);
                Additions LMT = new LightMotorTechnician();//Decorator pattern  for the display

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

                Console.WriteLine(LMT.Description() + "\nTotal Amount: " + LMT.Cost().ToString("C"));
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
                Additions HMT = new HeavyMotorTechnician();//Decorator pattern  for the display
                Notification o2 = new Notification("m");//observer pattern  for the display of uopdates for the vehicle
                newsletter.Attach(o2);
                diagnositics.Attach(o2);
                soundSystem.Attach(o2);

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

                Console.WriteLine(HMT.Description() + "\nTotal Amount: " + HMT.Cost().ToString("C"));
                Console.WriteLine();
                Console.WriteLine(lightMotorVehicle.GetDescription());


                //Observer functions
                //observer pattern  for the display of uopdates for the vehicle


                newsletter.Detach(o2);
                diagnositics.Detach(o2);
                soundSystem.Detach(o2);
                Console.WriteLine();

                //end of light motor vehicle
            }

            if (VehicleChoice.ToLower() == "bike")
            {
                Additions Bike = new MotorBikeTechnician();
                Notification o3 = new Notification("m");//observer pattern  for the display of uopdates for the vehicle 
                newsletter.Attach(o3);
                diagnositics.Attach(o3);
                soundSystem.Attach(o3);

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "y")
                {
                    Bike = new MBT_Camera(Bike);
                    Bike = new MBT_WiFi(Bike);
                    Bike = new MBT_SoundSystem(Bike);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    soundSystem.Notify("Update of Sound System", "MotorBike Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "y")
                {
                    Bike = new MBT_Camera(Bike);
                    Bike = new MBT_WiFi(Bike);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {
                    Bike = new MBT_Camera(Bike);
                    Bike = new MBT_SoundSystem(Bike);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {
                    Bike = new MBT_SoundSystem(Bike);
                    Bike = new MBT_WiFi(Bike);

                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    soundSystem.Notify("Update of Sound System", "MotorBike Vehicle");
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "y" && ChoiceCamera.ToLower() == "n")
                {

                    Bike = new MBT_WiFi(Bike);
                    Console.WriteLine();
                    diagnositics.Notify("Diagnosis", "MotorBike Vehicle");
                    newsletter.Notify("Discount of 20%", "MotorBike Vehicle");
                    Console.WriteLine();

                }

                if (SoundSystemChoice.ToLower() == "y" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "n")
                {
                    Bike = new MBT_SoundSystem(Bike);
                    Console.WriteLine();
                }

                if (SoundSystemChoice.ToLower() == "n" && WIFIChoice.ToLower() == "n" && ChoiceCamera.ToLower() == "y")
                {

                    Bike = new MBT_Camera(Bike);
                    Console.WriteLine();

                }

                Console.WriteLine(Bike.Description() + "\nTotal Amount- " + Bike.Cost().ToString("C"));
                Console.WriteLine();
                Console.WriteLine(motorBike.GetDescription());


                //Observer functions
                //observer pattern  for the display of uopdates for the vehicle


                newsletter.Detach(o3);
                diagnositics.Detach(o3);
                soundSystem.Detach(o3);
                Console.WriteLine();

                //end of Bike motor vehicle
            }

            Console.ReadLine();
        }
    }
}
