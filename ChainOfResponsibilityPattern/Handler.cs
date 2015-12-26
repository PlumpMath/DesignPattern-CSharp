using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void HandleRequest(int request);
    }
}
