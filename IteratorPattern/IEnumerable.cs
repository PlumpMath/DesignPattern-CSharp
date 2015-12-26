using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    interface IEnumerable<T>
    {
        IEumerator<T> GetEumerator();
    }
}
