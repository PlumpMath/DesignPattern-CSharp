using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    class ConcreteElementA : Element
    {
        public override void Accept(Visitor vistor)
        {
            vistor.VisitConcreteElementA(this);
        }

        public void OperationA()
        { }
    }

    class ConcreteElementB : Element
    {
        public override void Accept(Visitor vistor)
        {
            vistor.VisitConcreteElementB(this);
        }

        public void OperationB()
        { }
    }
}
