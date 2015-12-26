using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class DecoratorA : Decorator
    {
        public DecoratorA(Component component)
            : base(component)
        {
            // 添加装饰A的业务逻辑
            AddDecoratorA();
        }

        public void AddDecoratorA()
        {
            this.msg = component.msg + " AddDecoratorA";
        }
    }
}
