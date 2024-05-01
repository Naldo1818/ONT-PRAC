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

            Newsletter newsletter = new Newsletter();
            

            Additions LMTwithSoundAndWifi = new LightMotorTechnician();
            LMTwithSoundAndWifi = new LMT_SoundSystem(LMTwithSoundAndWifi);
            LMTwithSoundAndWifi = new LMT_WiFi(LMTwithSoundAndWifi);
            Console.WriteLine(LMTwithSoundAndWifi.Description() + "\nTotal Amount- " + LMTwithSoundAndWifi.Cost().ToString("C"));
            ObserverBase o1 = new ObserverBase("m");
            newsletter.Attach(o1);
            newsletter.Notify("Service");
            newsletter.Detach(o1);
            Console.WriteLine();

            Additions HMTwithWifiAndCameraAndSound = new HeavyMotorTechnician();
            HMTwithWifiAndCameraAndSound = new HMT_Camera(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_WiFi(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_SoundSystem(HMTwithWifiAndCameraAndSound);
            Console.WriteLine(HMTwithWifiAndCameraAndSound.Description() + "\nTotal Amount- " + HMTwithWifiAndCameraAndSound.Cost().ToString("C"));
            
            ObserverBase o2 = new ObserverBase("m");
            newsletter.Attach(o2);
            newsletter.Notify("Service");
            newsletter.Detach(o2);
            Console.WriteLine();

            Additions MBTwithWifi = new MotorBikeTechnician();
            MBTwithWifi = new LMT_SoundSystem(MBTwithWifi);
            Console.WriteLine(MBTwithWifi.Description() + "\nTotal Amount- " + MBTwithWifi.Cost().ToString("C"));
            
            ObserverBase o3 = new ObserverBase("m");
            newsletter.Attach(o3);
            newsletter.Notify("Service");
            newsletter.Detach(o3);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
