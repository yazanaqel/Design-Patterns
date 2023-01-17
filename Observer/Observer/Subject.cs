using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class Subject
    {
        private List<Observer> Observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }
        public void Notify()
        {
            foreach(Observer o in Observers)
            {
                o.UpDate();
            }
        }
    }
}