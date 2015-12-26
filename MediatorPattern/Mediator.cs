using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    abstract class Mediator
    {
        public abstract void Send(string meaasge, Colleague colleague);
    }
}
