using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecorator1 c1 = new ConcreteDecorator1();
            ConcreteDecorator2 c2 = new ConcreteDecorator2();

            c1.SetComponent(c);
            c2.SetComponent(c1);

            c2.Operation();
        }
    }
}
