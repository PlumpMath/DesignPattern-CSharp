using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 管理者
    /// </summary>
    class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
