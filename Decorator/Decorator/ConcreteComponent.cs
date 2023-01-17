using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteComponent : Compnent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}