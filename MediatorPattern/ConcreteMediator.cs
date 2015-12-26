using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    class ConcreteMediator : Mediator
    {
        public Colleague Colleague1 { get; set; }
        public Colleague Colleague2 { get; set; }

        public override void Send(string meaasge, Colleague colleague)
        {
            if (colleague == Colleague2)
            {
                Colleague1.Notify(meaasge);
            }
            else
            {
                Colleague2.Notify(meaasge);
            }
        }
    }
}
