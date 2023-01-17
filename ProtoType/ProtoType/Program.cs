using System;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("A");
            //ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();

            Console.WriteLine("Cloned: {0}", p1.ID);

            ConcretePrototype2 p2 = new ConcretePrototype2("B");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();

            Console.WriteLine("Cloned: {0}", p2.ID);
        }
    }
}
