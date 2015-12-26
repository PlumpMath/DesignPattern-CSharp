using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryPattern
{
    class SubOperation : Operation
    {
        public override double Calculate()
        {
            return NumberA - NumberB;
        }
    }
}
