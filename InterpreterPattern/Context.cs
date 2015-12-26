using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern
{
    /// <summary>
    /// 包含解释器之外的一些全局信息
    /// </summary>
    class Context
    {
        public string Input { get; set; }
        public string Output { get; set; }
    }
}
