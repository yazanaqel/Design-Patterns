using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDecorator1 : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator1.Operation()");
        }
    }


}