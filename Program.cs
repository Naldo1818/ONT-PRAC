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
        {

            Newsletter newsletter = new Newsletter();//calling the types of update notifications
            Diagnositics diagnositics = new Diagnositics();
            SoundSystem soundSystem = new SoundSystem();

            Additions LMTwithSoundAndWifi = new LightMotorTechnician();
            LMTwithSoundAndWifi = new LMT_SoundSystem(LMTwithSoundAndWifi);
            LMTwithSoundAndWifi = new LMT_WiFi(LMTwithSoundAndWifi);
            Console.WriteLine(LMTwithSoundAndWifi.Description() + "\nTotal Amount- " + LMTwithSoundAndWifi.Cost().ToString("C"));

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

            Additions HMTwithWifiAndCameraAndSound = new HeavyMotorTechnician();
            HMTwithWifiAndCameraAndSound = new HMT_Camera(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_WiFi(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_SoundSystem(HMTwithWifiAndCameraAndSound);
            Console.WriteLine(HMTwithWifiAndCameraAndSound.Description() + "\nTotal Amount- " + HMTwithWifiAndCameraAndSound.Cost().ToString("C"));
            
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

            Additions MBTwithWifi = new MotorBikeTechnician();
            MBTwithWifi = new LMT_SoundSystem(MBTwithWifi);
            Console.WriteLine(MBTwithWifi.Description() + "\nTotal Amount- " + MBTwithWifi.Cost().ToString("C"));
            
            ObserverBase o3 = new ObserverBase("m");//observer pattern  for the display of uopdates for the vehicle 
            newsletter.Attach(o3);
            diagnositics.Attach(o3);
            diagnositics.Notify("Diagnosis", "Motorbike");
            newsletter.Notify("Discount of 20%", "Motorbike");
            newsletter.Detach(o3);
            diagnositics.Detach(o3);
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
