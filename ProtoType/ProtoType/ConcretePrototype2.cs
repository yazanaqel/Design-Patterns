using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }

        public override Prototype Clone()
        {
            //shallow copy
            return (Prototype)this.MemberwiseClone();
        }
    }
}
