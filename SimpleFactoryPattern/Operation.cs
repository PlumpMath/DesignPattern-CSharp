using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryPattern
{
    abstract class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public abstract double Calculate();
    }
}
