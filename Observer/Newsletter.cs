using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Observer
{
    //concrete sbuject base
    internal class Newsletter:SubjectBase
    {
        private string message;
        private string vehicle;
        private string New1;
        public string _newsletter
        {
            get { return New1; }
            set 
            {
                if (New1 != value)
                {
                    New1 = value;
                    Notify(message, vehicle);
                } 
            }
        }
    }
}
