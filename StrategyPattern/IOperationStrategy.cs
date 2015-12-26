using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 抽象策略对象
    /// </summary>
    interface IOperationStrategy
    {
        double GetResult(double numA, double numB);
    }
}
