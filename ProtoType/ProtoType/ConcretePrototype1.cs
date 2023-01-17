using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }

        public override Prototype Clone()
        {
            //shallow copy
            return (Prototype)this.MemberwiseClone();
        }
    }
}
