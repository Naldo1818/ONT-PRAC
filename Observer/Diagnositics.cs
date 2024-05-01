using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Observer
{
    internal class Diagnositics:SubjectBase
    {
        private string message;
        private string vehicle;
        private string Diag1;
        public string Diagnostic
        {
            get { return Diag1; }
            set
            {
                if (Diag1 != value)
                {
                    Diag1 = value;
                    Notify(message,vehicle);
                }
            }
        }
    }
}
