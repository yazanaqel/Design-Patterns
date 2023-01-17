using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDecorator2 : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecorator2.Operation()");
        }
        void AddedBehavior()
        {

        }
    }
}