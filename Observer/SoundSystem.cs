using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Observer
{
    internal class SoundSystem:SubjectBase
    {
        private string message;
        private string vehicle;
        private string sound;
        public string _SoundSystem
        {
            get { return sound; }
            set
            {
                if (sound != value)
                {
                    sound = value;
                    Notify(message,vehicle);
                }
            }
        }
    }
}
