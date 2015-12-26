using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class ConcreteCommand : Command
    {
        public override void Execute()
        {
            receiver.Action();
        }

        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        { }
    }
}
