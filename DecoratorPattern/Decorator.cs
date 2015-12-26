using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    abstract class Decorator : Component
    {
        public Decorator(Component component)
        {
            this.component = component;
        }

        protected Component component;
    }
}
