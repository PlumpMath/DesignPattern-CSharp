using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 环境对象：该类中实现了对抽象策略中定义的接口或者抽象类的引用。
    /// </summary>
    class OperationContext
    {
        IOperationStrategy strategy = null;
        public OperationContext(IOperationStrategy strategy)
        {
            this.strategy = strategy;
        }

        // 运用简单工厂产生策略
        public OperationContext(string operate)
        {
            switch (operate)
            {
                case "+":
                    strategy = new AddStrtegy();
                    break;
                case "-":
                    //strategy = new SubStrtegy();
                    break;
                default: break;
            }
        }

        public double GetResult(double numA, double numB)
        {
            double result = 0.0;
            if (strategy != null)
            {
                result = strategy.GetResult(numA, numB);
            }
            return result;
        }
    }
}
