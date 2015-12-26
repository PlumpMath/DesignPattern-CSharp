using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    interface IEumerator<T>
    {
        T Current { get; }
        bool MoveNext();
        void Reset();
    }
}
