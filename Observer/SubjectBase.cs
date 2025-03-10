﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_PRAC.Observer
{
    internal class SubjectBase
    {
        public List<IObserver> observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify(string Newsletters, string Vehicle)
        {
            foreach(var x in observers)
            {
                x.Update(Newsletters, Vehicle);
            }
        }


    }
}
