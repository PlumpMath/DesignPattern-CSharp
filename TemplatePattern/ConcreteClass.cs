using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("A1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("A2");
        }
    }

    class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("B1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("B2");
        }
    }
}
