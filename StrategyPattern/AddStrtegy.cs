using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 具体策略对象
    /// </summary>
    class AddStrtegy : IOperationStrategy
    {
        public double GetResult(double numA, double numB)
        {
            return numA + numB;
        }
    }
}
