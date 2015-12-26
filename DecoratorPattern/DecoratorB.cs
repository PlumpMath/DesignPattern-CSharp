using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class DecoratorB : Decorator
    {
        public DecoratorB(Component component)
            : base(component)
        {
            // 添加装饰B的业务逻辑
            AddDecoratorB();
        }
        
        public void AddDecoratorB()
        {
            this.msg = component.msg + " AddDecoratorB";
        }
    }
}
