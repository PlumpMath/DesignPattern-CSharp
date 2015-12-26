using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryPattern
{
    class AddOperation : Operation
    {
        public override double Calculate()
        {
            return NumberA + NumberB;
        }
    }
}
