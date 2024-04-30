using ONT_PRAC.Decorator;
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
            Additions LMTwithSoundAndWifi = new LightMotorTechnician();
            LMTwithSoundAndWifi = new LMT_SoundSystem(LMTwithSoundAndWifi);
            LMTwithSoundAndWifi = new LMT_WiFi(LMTwithSoundAndWifi);
            Console.WriteLine(LMTwithSoundAndWifi.Description() + "\nTotal Amount- " + LMTwithSoundAndWifi.Cost().ToString("C"));
            Console.WriteLine();

            Additions HMTwithWifiAndCameraAndSound = new HeavyMotorTechnician();
            HMTwithWifiAndCameraAndSound = new HMT_Camera(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_WiFi(HMTwithWifiAndCameraAndSound);
            HMTwithWifiAndCameraAndSound = new HMT_SoundSystem(HMTwithWifiAndCameraAndSound);
            Console.WriteLine(HMTwithWifiAndCameraAndSound.Description() + "\nTotal Amount- " + HMTwithWifiAndCameraAndSound.Cost().ToString("C"));
            Console.WriteLine();

            Additions MBTwithWifi = new MotorBikeTechnician();
            MBTwithWifi = new LMT_SoundSystem(MBTwithWifi);
            Console.WriteLine(MBTwithWifi.Description() + "\nTotal Amount- " + MBTwithWifi.Cost().ToString("C"));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
