using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    class Client
    {
        ConcreteMediator mediator;
        Colleague colleague1;
        Colleague colleague2;

        void Test()
        {
            mediator = new ConcreteMediator();

            colleague1 = new ConcreteColleague1(mediator);
            colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("同志们好！");
            colleague2.Send("首长好！");
        }

        static void Main(string[] args)
        {
            new Client().Test();
            Console.ReadKey();
        }
    }
}
