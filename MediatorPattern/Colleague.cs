using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    abstract class Colleague
    {
        protected Mediator meditor;

        public Colleague(Mediator meditor)
        {
            this.meditor = meditor;
        }

        public void Send(string message)
        {
            meditor.Send(message, this);
        }

        public abstract void Notify(string meaasge);
    }
}
