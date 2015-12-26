using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }
    
        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
