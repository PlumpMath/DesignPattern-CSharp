using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string meaasge)
        {
            Console.WriteLine("Colleague1接收到信息：" + meaasge);
        }
    }

    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string meaasge)
        {
            Console.WriteLine("Colleague2接收到信息：" + meaasge);
        }
    }
}
