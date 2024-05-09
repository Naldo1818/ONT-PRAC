using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Observer
{
    //concrete observer
    public class Notification:IObserver
    {
        private string _newsletter;
        public Notification(string NewsMessage)
        {
            this._newsletter = NewsMessage;
        }
        public void Update(string NewsMessage, string Vehicle)
        {
            Console.WriteLine($"{NewsMessage} for this {Vehicle} is availible");
        }
    }
}
