using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVistor1 v1 = new ConcreteVistor1();
            ConcreteVistor2 v2 = new ConcreteVistor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.ReadKey();
        }
    }
}
