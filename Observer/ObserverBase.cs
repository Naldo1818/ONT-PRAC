using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Observer
{
    //concrete observer
    public class ObserverBase:IObserver
    {
        private string _newsletter;
        public ObserverBase(string NewsMessage)
        {
            this._newsletter = NewsMessage;
        }
        public void Update(string NewsMessage)
        {
            Console.WriteLine($"{NewsMessage} for this vehicle is availible");
        }
    }
}
