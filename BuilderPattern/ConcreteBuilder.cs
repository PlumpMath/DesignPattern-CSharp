using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class ConcreteBuilder : Builder
    {
        public override void BuildPartA()
        {
            base.product.Add("部件A.");
        }

        public override void BuildPartB()
        {
            base.product.Add("部件B");
        }
    }
}
