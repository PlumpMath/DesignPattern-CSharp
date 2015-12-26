using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录
    /// </summary>
    class Memento
    {
        public string State { get; set; }

        public Memento(string State)
        {
            this.State = State;
        }
    }
}
