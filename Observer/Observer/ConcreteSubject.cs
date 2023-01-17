using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteSubject : Subject
    {
        private string _subjectstate;
        public string subjectstate
        {
            get { return _subjectstate; }
            set { _subjectstate = value; }
        }
    }
}