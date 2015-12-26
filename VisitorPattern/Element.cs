using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    abstract class Element
    {
        public abstract void Accept(Visitor vistor);
    }
}
