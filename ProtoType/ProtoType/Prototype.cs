using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    abstract class Prototype
    {
        string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string ID { get { return id; } }

        public abstract Prototype Clone();
    }
}
