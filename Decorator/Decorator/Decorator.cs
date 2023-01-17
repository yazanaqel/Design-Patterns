using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Decorator : Compnent
    {
        protected Compnent Component;
        public void SetComponent(Compnent Component)
        {
            this.Component = Component;
        }
        public override void Operation()
        {
            if(Component != null)
            {
                Component.Operation();
            }
        }
    }
}