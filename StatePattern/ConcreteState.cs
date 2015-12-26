using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class ConcreteStateA : State
    {
        public override void Handle()
        {
            Console.WriteLine("当前状态是A");
        }
    }

    class ConcreteStateB : State
    {
        public override void Handle()
        {
            Console.WriteLine("当前状态是B");
        }
    }
}
