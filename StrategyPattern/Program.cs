using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        /**
           策略模式中有三个对象：
            （1）环境对象：该类中实现了对抽象策略中定义的接口或者抽象类的引用。
            （2）抽象策略对象：它可由接口或抽象类来实现。
            （3）具体策略对象：它封装了实现同不功能的不同算法。
         */
        static void Main(string[] args)
        {
            OperationContext ctx = new OperationContext("+");
            var result = ctx.GetResult(1, 2);

            System.Console.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}
