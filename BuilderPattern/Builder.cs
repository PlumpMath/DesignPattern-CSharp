using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    abstract class Builder
    {
        protected Product product = new Product();

        public abstract void BuildPartA();
        public abstract void BuildPartB();

        public Product GetResult()
        {
            return product;
        }
    }
}
