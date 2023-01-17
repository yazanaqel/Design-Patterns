using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerstate;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this.name = name;
        }
        public override void UpDate()
        {
            observerstate = _subject.subjectstate;
            Console.WriteLine("Observer: {0}'s new state is: {1}", name, observerstate);
            
        }
        public ConcreteSubject subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}