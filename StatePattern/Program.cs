using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /*
     1. 概述

　　    当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类。

    2. 解决的问题

　　    主要解决的是当控制一个对象状态转换的条件表达式过于复杂时的情况。把状态的判断逻辑转移到表示不同的一系列类当中，可以把复杂的逻辑判断简单化。

    3. 模式中的角色

　　    3.1 上下文环境（Context）：它定义了客户程序需要的接口并维护一个具体状态角色的实例，将与状态相关的操作委托给当前的Concrete State对象来处理。

　　    3.2 抽象状态（State）：定义一个接口以封装使用上下文环境的的一个特定状态相关的行为。

　　    3.3 具体状态（Concrete State）：实现抽象状态定义的接口。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();

            context.State = new ConcreteStateB();
            context.Request();

            Console.ReadKey();
        }
    }
}
